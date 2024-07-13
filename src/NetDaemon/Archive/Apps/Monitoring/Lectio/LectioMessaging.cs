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
  private readonly ILogger<LectioMessaging> logger;
  private readonly INotificationBuilder notificationBuilder;
  private readonly LectioMessagingModel messaging;
  private readonly IConfiguration config;
  private readonly NotifyServices notifyService;

  public LectioMessaging(
    IHaContext ha,
    IAppConfig<LectioConfig> appConfig,
    IConfiguration config,
    INetDaemonScheduler scheduler,
    ILogger<LectioMessaging> logger,
    IHttpClientFactory httpClientFactory,
    INotificationBuilder notificationBuilder) : base(httpClientFactory)
  {
    this.config = config;
    this.logger = logger;
    this.notificationBuilder = notificationBuilder;
    var lectioModel = new LectioModel(appConfig.Value, logger, httpClientFactory);
    messaging = new LectioMessagingModel(lectioModel);
    notifyService = new NotifyServices(ha);

    UpdateMessagesAsync();
    scheduler.RunEvery(FromHours(1), UpdateMessagesAsync);
  }

  private async void UpdateMessagesAsync()
  {
    try
    {
      var messages = await messaging.GetMessagesAsync(FromHours(1));
      foreach (var message in messages)
      {
        notificationBuilder
          .SetTitle(message.Title)
          .SetChannel("Beskeder")
          .SetColor(LightSteelBlue)
          .SetMessage(message.Message)
          .AddActionUri("Se besked", ActionUri.Uri(message.Link))
          .Notify(notifyService.KristoffersTelefon);
      }
    }
    catch (Exception e)
    {
      logger.LogErrorMethod(e);
      notificationBuilder.Presets.NotifyAppException(e);
    }
  }
}