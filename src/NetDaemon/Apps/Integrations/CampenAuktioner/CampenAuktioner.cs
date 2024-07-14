using Lerbaek.Auctions.CampenAuktioner;

namespace Lerbaek.NetDaemon.Apps.Integrations.CampenAuktioner;

//[Focus]
[NetDaemonApp]
public class CampenAuktioner
{
  private readonly IFileSystem _fileSystem;
  private readonly INotificationBuilder _notificationBuilder;
  private readonly ILogger<CampenAuktioner> _logger;
  private readonly IHaContext _haContext;
  private readonly IServices _services;
  private readonly VarEntities _varEntities;
  private readonly CampenAuktionerSite _campenAuktionerSite;

  public CampenAuktioner(IHaContext               ha,
                         INetDaemonScheduler      scheduler,
                         ILogger<CampenAuktioner> logger,
                         IHttpClientFactory       httpClientFactory,
                         IFileSystem              fileSystem,
                         INotificationBuilder     notificationBuilder)
  {
    _fileSystem = fileSystem;
    _notificationBuilder = notificationBuilder;
    _logger = logger;
    _haContext = ha;
    _services = new Services(ha);
    _varEntities = new VarEntities(ha);
    try
    { 
      var httpClient = httpClientFactory.CreateClient(nameof(CampenAuktioner));
      _campenAuktionerSite = new CampenAuktionerSite(logger, httpClient);

      _ = CheckForMatches("startup search");

      _varEntities.CampenWatchlist
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
      _logger.LogError("An error occurred on {Context}.", context);
      _logger.LogError("{Exception}", e.ToString());
    }
  }

  private async Task CheckForMatches()
  {
    var watchlist = _varEntities.CampenWatchlist
      .State!
      .Split('\n', StringSplitOptions.RemoveEmptyEntries);

    var matches = (await _campenAuktionerSite.GetMatchesAsync(watchlist)).ToArray();

    SetMatches(string.Join($"{NewLine}---{NewLine}", matches.Select(m => m.Markdown)));
    Notify([.. matches]);
  }

  private void Notify(CampenAuktionerItem[] matches)
  {
    const string fileName = "alerted.txt";
    if (!_fileSystem.File.Exists(fileName))
      _fileSystem.File.Create(fileName).Dispose();
    
    var alerted = _fileSystem.File
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
        _logger.LogDebug("Skipping {Title} because a notification has previously been sent.", match.Title);
        continue;
      }

      _logger.LogInformation("Match: {Title}", match.Title);
      _notificationBuilder.SetMessage(match.Description!)
                         .SetTitle(match.Title!)
                         .SetImage(match.ImageLink!)
                         .AddActionUri("Open", ActionUri.Uri(match.Link!))
                         .Notify(_services.Notify.KristoffersTelefon);
    }

    _fileSystem.File
              .WriteAllText(fileName,
                            string.Join(NewLine,
                                        alerted.Union(matches.Select(m => $"{DateTime.Now + m.TimeLeft:yyyyMMdd} {m.Id}"))));
  }

  private void SetMatches(string markdown, int matchCount = 0)
  {
    _haContext.CallService("netdaemon",
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