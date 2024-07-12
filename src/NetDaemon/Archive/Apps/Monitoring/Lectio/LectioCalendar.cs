using Lerbaek.Calendar.Lectio;
using Lerbaek.Lectio;

namespace Lerbaek.NetDaemon.Archive.Apps.Monitoring.Lectio;

//[NetDaemonApp]
//[Focus]
public class LectioCalendar
{
    private readonly ILogger<LectioCalendar> logger;
    private readonly INotificationBuilder notificationBuilder;
    private readonly LectioCalendarModel calendar;
    private readonly NotifyServices notifyServices;

    public LectioCalendar(
      IHaContext haContext,
      IAppConfig<LectioConfig> config,
      INetDaemonScheduler scheduler,
      ILogger<LectioCalendar> logger,
      IHttpClientFactory httpClientFactory,
      INotificationBuilder notificationBuilder)
    {
        this.logger = logger;
        this.notificationBuilder = notificationBuilder;
        var lectioModel = new LectioModel(config.Value, logger, httpClientFactory);
        calendar = new LectioCalendarModel(lectioModel);
        notifyServices = new NotifyServices(haContext);

        UpdateCalendar();
        scheduler.RunEvery(FromHours(1), UpdateCalendar);
    }

    private async void UpdateCalendar()
    {
        // ReSharper disable once UnusedVariable because the usage is hidden by a compiler instruction
        const string calendarEndPath = "calendar";
        const string calendarFilename = "gro-vuc.ics";
        var path = Path.Combine(
#if DEPLOY
      "/config", "www", calendarEndPath,
#else
          Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!,
#endif
          calendarFilename);
        try
        {
            var result = await calendar.SaveCalendar(path, "Gro, VUC");
            if (!result.IsFailed)
                return;

            if (result.Errors.Contains(LectioError.BadCredentials))
                notificationBuilder
                  .SetMessage("Ugyldigt brugernavn eller adgangskode.")
                  .SetTag($"{nameof(LectioError)}{nameof(LectioError.BadCredentials)}");
            else if (result.Errors.Contains(LectioError.AttributeNotFound))
            {
                var missingAttributes = string.Join(
                  ", ",
                  result.Errors
                    .Where(e => e.Equals(LectioError.AttributeNotFound))
                    .SelectMany(e => e.Metadata.Values));
                notificationBuilder
                  .SetMessage(
                    $"Attribut ikke fundet: {missingAttributes}")
                  .SetTag($"{nameof(LectioError)}{nameof(LectioError.AttributeNotFound)}");
            }
            logger.LogError("An error occurred while trying to update {Calendar}. Reason: {Reason}",
              nameof(LectioCalendar),
              string.Join(", ", result.Reasons.Select(r =>
              $"{r.Message}" + (r.Metadata.Any() ? $": {string.Join(", ", r.Metadata.Values)}" : ""))));
            SendNotification();

#if DEPLOY
      logger.LogInformation("Internet calendar {path} has been updated.", $"https://homeassistant.lerbaek.dk/local/{calendarEndPath}/{calendarFilename}");
#endif
        }
        catch (Exception e)
        {
            logger.LogError(e, "An error occurred while trying to update {Calendar}", nameof(LectioCalendar));
            notificationBuilder
              .SetMessage(e.ToString())
              .SetTag($"{nameof(LectioError)}{nameof(Exception)}");
            SendNotification();
        }
    }

    private void SendNotification()
    {
        notificationBuilder
          .SetTitle("Fejl: Lectio calendar")
          .SetChannel(nameof(LectioError))
          .MakeSticky()
          .SetColor(Red)
          .Notify(notifyServices.KristoffersTelefon);
    }
}