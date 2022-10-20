using Lerbaek.Auctions.CampenAuktioner;

namespace Lerbaek.NetDaemon.Apps.Integrations.CampenAuktioner;

//[Focus]
[NetDaemonApp]
public class CampenAuktioner
{
  private readonly IFileSystem fileSystem;
  private readonly INotificationBuilder notificationBuilder;
  private readonly ILogger<CampenAuktioner> logger;
  private readonly IHaContext haContext;
  private readonly IServices services;
  private readonly VarEntities varEntities;
  private readonly CampenAuktionerSite campenAuktionerSite;

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
      var httpClient = httpClientFactory.CreateClient(nameof(CampenAuktioner));
      campenAuktionerSite = new CampenAuktionerSite(logger, httpClient);

      _ = CheckForMatches("startup search");

      varEntities.CampenWatchlist
        .StateChanges()
        .Where(s => s.Old?.State != s.New?.State)
        .Subscribe(_ => CheckForMatches("updated watch list").Wait());

      scheduler.RunEvery(FromHours(12), () => CheckForMatches("scheduled search").Wait());
    }
    catch
    {
      logger.LogError("An error occurred on startup.");
      throw;
    }
  }

  private async Task CheckForMatches(string context)
  {
    try
    {
      SetMatches("Searching ...");
      await CheckForMatches();
    }
    catch (Exception e)
    {
      logger.LogError($"An error occurred on {context}.");
      logger.LogError("{Exception}", e.ToString());
    }
  }

  private async Task CheckForMatches()
  {
    var watchlist = varEntities.CampenWatchlist
      .State!
      .Split('\n', StringSplitOptions.RemoveEmptyEntries);

    var matches = (await campenAuktionerSite.GetMatchesAsync(watchlist)).ToArray();

    SetMatches(string.Join($"{NewLine}---{NewLine}", matches.Select(m => m.Markdown)));
    Notify(matches.ToArray());
  }

  private void Notify(CampenAuktionerItem[] matches)
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
                         .AddActionUri("Open", ActionUri.Uri(match.Link!))
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
}