using Lerbaek.Calendar.Lectio;
using Lerbaek.Lectio;

namespace Lerbaek.NetDaemon.Apps.Monitoring.Lectio;

[NetDaemonApp]
//[Focus]
public class LectioCalendar
{
  private readonly ILogger<LectioCalendar> logger;
  private readonly LectioCalendarModel calendar;

  public LectioCalendar(
    IAppConfig<LectioConfig> config,
    INetDaemonScheduler scheduler,
    ILogger<LectioCalendar> logger,
    IHttpClientFactory httpClientFactory)
  {
    this.logger = logger;
    var lectioModel = new LectioModel(config.Value, logger, httpClientFactory);
    calendar = new LectioCalendarModel(lectioModel);

    UpdateCalendar();
    scheduler.RunEvery(FromHours(1), UpdateCalendar);
  }

  private async void UpdateCalendar()
  {
    const string calendarEndPath = "calendar";
    const string calendarFilename = "gro-vuc.ics";
    var path = Path.Combine(
#if DEPLOY
      "/config", "www", calendarEndPath,
#else
      Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!,
#endif
      calendarFilename);
    await calendar.SaveCalendar(path, "Gro, VUC");
#if DEPLOY
    logger.LogInformation("Internet calendar {path} has been updated.", $"https://homeassistant.lerbaek.dk/local/{calendarEndPath}/{calendarFilename}");
#endif
  }
}