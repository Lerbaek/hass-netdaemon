using Lerbaek.Lectio;
using Lerbaek.Messaging.Lectio;
using Lerbaek.NetDaemon.Common.Logging;
using Microsoft.Extensions.Configuration;

namespace Lerbaek.NetDaemon.Archive.Apps.Monitoring.Lectio;

public abstract class Lectio(IHttpClientFactory httpClientFactory)
{
  protected HttpClient HttpClient = httpClientFactory.CreateClient(nameof(Lectio));
}

//[NetDaemonApp]
//[Focus]
public class LectioMessaging : Lectio
{
  private readonly ILogger<LectioMessaging> _logger;
  private readonly INotificationBuilder _notificationBuilder;
  private readonly LectioMessagingModel _messaging;
  private readonly NotifyServices _notifyService;

  public LectioMessaging(
    IHaContext ha,
    IAppConfig<LectioConfig> appConfig,
    INetDaemonScheduler scheduler,
    ILogger<LectioMessaging> logger,
    IHttpClientFactory httpClientFactory,
    INotificationBuilder notificationBuilder) : base(httpClientFactory)
  {
    this._logger = logger;
    this._notificationBuilder = notificationBuilder;
    var lectioModel = new LectioModel(appConfig.Value, logger, httpClientFactory);
    _messaging = new LectioMessagingModel(lectioModel);
    _notifyService = new NotifyServices(ha);

    UpdateMessagesAsync();
    scheduler.RunEvery(FromHours(1), UpdateMessagesAsync);
  }

  private async void UpdateMessagesAsync()
  {
    try
    {
      var messages = await _messaging.GetMessagesAsync();
      foreach (var message in messages)
      {
        _notificationBuilder
          .SetTitle(message.Title)
          .SetChannel("Beskeder")
          .SetColor(LightSteelBlue)
          .SetMessage(message.Message)
          .AddActionUri("Se besked", ActionUri.Uri(message.Link))
          .Notify(_notifyService.KristoffersTelefon);
      }
    }
    catch (Exception e)
    {
      _logger.LogErrorMethod(e);
      _notificationBuilder.Presets.NotifyAppException(e);
    }
  }
}