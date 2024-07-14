using Lerbaek.Calendar.Lectio;
using Lerbaek.Lectio;

namespace Lerbaek.NetDaemon.Archive.Apps.Monitoring.Lectio;

//[NetDaemonApp]
//[Focus]
public class LectioCalendar
{
    private readonly ILogger<LectioCalendar> _logger;
    private readonly INotificationBuilder _notificationBuilder;
    private readonly LectioCalendarModel _calendar;
    private readonly NotifyServices _notifyServices;

    public LectioCalendar(
      IHaContext haContext,
      IAppConfig<LectioConfig> config,
      INetDaemonScheduler scheduler,
      ILogger<LectioCalendar> logger,
      IHttpClientFactory httpClientFactory,
      INotificationBuilder notificationBuilder)
    {
        _logger = logger;
        _notificationBuilder = notificationBuilder;
        var lectioModel = new LectioModel(config.Value, logger, httpClientFactory);
        _calendar = new LectioCalendarModel(lectioModel);
        _notifyServices = new NotifyServices(haContext);

        UpdateCalendar();
        scheduler.RunEvery(FromHours(1), UpdateCalendar);
    }

    private async void UpdateCalendar()
    {
        // ReSharper disable once UnusedVariable because the usage is hidden by a compiler instruction
#if DEPLOY
        const string calendarEndPath = "calendar";
#endif
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
            var result = await _calendar.SaveCalendar(path, "Gro, VUC");
            if (!result.IsFailed)
                return;

            if (result.Errors.Contains(LectioError.BadCredentials))
                _notificationBuilder
                  .SetMessage("Ugyldigt brugernavn eller adgangskode.")
                  .SetTag($"{nameof(LectioError)}{nameof(LectioError.BadCredentials)}");
            else if (result.Errors.Contains(LectioError.AttributeNotFound))
            {
                var missingAttributes = string.Join(
                  ", ",
                  result.Errors
                    .Where(e => e.Equals(LectioError.AttributeNotFound))
                    .SelectMany(e => e.Metadata.Values));
                _notificationBuilder
                  .SetMessage(
                    $"Attribut ikke fundet: {missingAttributes}")
                  .SetTag($"{nameof(LectioError)}{nameof(LectioError.AttributeNotFound)}");
            }

            _logger.LogError("An error occurred while trying to update {Calendar}. Reason: {Reason}",
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
            _logger.LogError(e, "An error occurred while trying to update {Calendar}", nameof(LectioCalendar));
            _notificationBuilder
              .SetMessage(e.ToString())
              .SetTag($"{nameof(LectioError)}{nameof(Exception)}");
            SendNotification();
        }
    }

    private void SendNotification()
    {
        _notificationBuilder
          .SetTitle("Fejl: Lectio calendar")
          .SetChannel(nameof(LectioError))
          .MakeSticky()
          .SetColor(Red)
          .Notify(_notifyServices.KristoffersTelefon);
    }
}