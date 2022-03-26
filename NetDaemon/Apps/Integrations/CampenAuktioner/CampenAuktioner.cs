using System.Security.Cryptography.X509Certificates;
using Lerbaek.NetDaemon.Common.Notifications;

namespace Lerbaek.NetDaemon.Apps.Integrations.CampenAuktioner;

//[Focus]
[NetDaemonApp]
public partial class CampenAuktioner
{
  private readonly IFileSystem fileSystem;
  private readonly INotificationBuilder notificationBuilder;
  private readonly ILogger<CampenAuktioner> logger;
  private readonly IHaContext haContext;
  private readonly HttpClient httpClient;
  private readonly IServices services;
  private readonly VarEntities varEntities;

  public CampenAuktioner(IHaContext               ha,
                         INetDaemonScheduler      scheduler,
                         ILogger<CampenAuktioner> logger,
                         IHttpClientFactory       httpClientFactory,
                         IFileSystem              fileSystem,
                         INotificationBuilder     notificationBuilder)
  {
    this.fileSystem = fileSystem;
    this.notificationBuilder = notificationBuilder;
    this.logger = logger;
    haContext = ha;
    services = new Services(ha);
    varEntities = new VarEntities(ha);
    try
    {
      httpClient = httpClientFactory.CreateClient(nameof(CampenAuktioner));
      CancellationTokenSource? cancellationTokenSource = null;

      StartNewCheckForMatches("startup search");

      void StartNewCheckForMatches(string context)
      {
        try
        {
          SetMatches("Searching ...");
          cancellationTokenSource?.Cancel();
          cancellationTokenSource = new CancellationTokenSource();
          CheckForMatches(cancellationTokenSource.Token).Wait();
        }
        catch (Exception e)
        {
          logger.LogError($"An error occurred on {context}.");
          logger.LogError("{Exception}", e.ToString());
        }
      }

      varEntities.CampenWatchlist
        .StateChanges()
        .Where(s => s.Old?.State != s.New?.State)
        .Subscribe(_ => StartNewCheckForMatches("updated watch list"));

      scheduler.RunEvery(FromHours(12), () => StartNewCheckForMatches("scheduled search"));
    }
    catch
    {
      logger.LogError("An error occurred on startup.");
      throw;
    }
  }

  private async Task CheckForMatches(CancellationToken cancellationToken)
  {
    var items = (await GetResults(cancellationToken))?.ToArray();
    if (cancellationToken.IsCancellationRequested || items is null)
      return;
    var watchlist = varEntities.CampenWatchlist
                               .State!
                               .Split('\n')
                               .Select(line => line.ToLowerInvariant()
                                                   .Split(' ')
                                                   .GroupBy(word => !word.StartsWith('-')));
    if (cancellationToken.IsCancellationRequested)
      return;
    var matches = items.Where(i => i.Matches(watchlist)).ToArray();
    if (cancellationToken.IsCancellationRequested)
      return;

    var markdown = string.Join($"{NewLine}{NewLine}---{NewLine}{NewLine}", matches.Select(m => m.Markdown));
    if (cancellationToken.IsCancellationRequested)
      return;

    SetMatches(markdown, matches.Length);
    if (cancellationToken.IsCancellationRequested)
      return;
    Notify(matches);
  }

  private void Notify(Item[] matches)
  {
    const string fileName = "alerted.txt";
    if (!fileSystem.File.Exists(fileName))
      fileSystem.File.Create(fileName).Dispose();
    var alerted = fileSystem.File
                            .ReadAllText(fileName)
                            .Split(NewLine)
                            .Where(l =>
      DateTime.TryParseExact(l.Split()
                              .First(),
                             "yyyyMMdd",
                             CultureInfo.InvariantCulture,
                             DateTimeStyles.None,
                             out var endDate)
      && endDate >= DateTime.Today)
                            .ToArray();

    foreach (var match in matches.Where(m => m.Active))
    {
      if (alerted.Any(m => m.Contains(match.Id!)))
      {
        logger.LogDebug("Skipping {Title} because a notification has previously been sent.", match.Title);
        continue;
      }

      logger.LogInformation("Match: {Title}", match.Title);
      notificationBuilder.SetMessage(match.Description!)
                         .SetTitle(match.Title!)
                         .SetImage(match.ImageLink!)
                         .AddAction("Open", ActionUri.Uri(match.Link!))
                         .Notify(services.Notify.MobileAppKristoffersGalaxyS20Ultra);
    }

    fileSystem.File
              .WriteAllText(fileName,
                            string.Join(NewLine,
                                        alerted.Union(matches.Select(m => $"{DateTime.Now + m.TimeLeft:yyyyMMdd} {m.Id}"))));
  }

  private void SetMatches(string markdown, int matchCount = 0)
  {
    haContext.CallService("netdaemon",
      $"entity_{(typeof(SensorEntities).GetProperty("CampenWatchlist") == null ? "create" : "update")}", null, new
      {
        entity_id = "sensor.campen_watchlist",
        state = $"{matchCount} match{(matchCount == 1 ? "" : "es")}",
        icon = "mdi:gavel",
        attributes = new
        {
          markdown
        }
      });
  }

  private async Task<IEnumerable<Item>?> GetResults(CancellationToken cancellationToken)
  {
    try
    {
      var page1 = await GetPage(1, cancellationToken);
      if (cancellationToken.IsCancellationRequested || page1 is null)
        return default;
      var page1Results = new Dictionary<int, IEnumerable<Item>> {{ 1, ParseItems(page1) }};
      var results = new ConcurrentDictionary<int, IEnumerable<Item>>(page1Results);
      Parallel.For(2, page1["pageCount"]!.Value<int>() + 1,
        i =>
        {
          var retries = 10;
          while (retries --> 0)
          {
            try
            {
              var page = GetPage(i, cancellationToken).Result;
              if (cancellationToken.IsCancellationRequested || page is null)
                return;
              var result = ParseItems(page);
              results.TryAdd(i, result);
              return;
            }
            catch
            {
              // ignored
            }
          }
        });
      return cancellationToken.IsCancellationRequested
        ? default
        : results.SelectMany(r => r.Value);
    }
    catch (Exception )
    {
      return default;
    }
  }

  private static IEnumerable<Item> ParseItems(JObject page)
  {
    if (page == null)
      throw new ArgumentNullException(nameof(page));
    return page["results"]!.Select(r => new Item(r)).Where(item => item.Active);
  }

  private async Task<JObject?> GetPage(int page, CancellationToken cancellationToken)
  {
    var apiLink = GetApiLink(page);
    try
    {
      await using var stream = await httpClient.GetStreamAsync(apiLink, cancellationToken);
      if (cancellationToken.IsCancellationRequested)
        return default;
      using var streamReader = new StreamReader(stream);
      using JsonReader jsonReader = new JsonTextReader(streamReader);
      return await JObject.LoadAsync(jsonReader, cancellationToken);
    }
    catch (OperationCanceledException)
    {
      return default;
    }
    catch (AggregateException)
    {
      return default;
    }
    catch (HttpRequestException)
    {
      throw;
    }
    catch (Exception)
    {
      System.Diagnostics.Debugger.Break();
      throw;
    }
  }

  private static string GetApiLink(int page) => $"http://campenauktioner.hibid.com/api/v1/lot/list?pn={page}&ipp=100&isArchive=false";
}