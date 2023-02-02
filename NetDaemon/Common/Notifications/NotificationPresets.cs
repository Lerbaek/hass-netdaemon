using System.Diagnostics;
using Lerbaek.NetDaemon.Apps.Automations.ChestFreezer;
using Lerbaek.NetDaemon.Common.Logging;
using Microsoft.Extensions.Configuration;

namespace Lerbaek.NetDaemon.Common.Notifications;

public class NotificationPresets : INotificationPresets
{
  private readonly INotificationBuilder notificationBuilder;
  private readonly string logUrl;
  private readonly NotifyServices notifyServices;

  public NotificationPresets(IHaContext ha, IConfiguration config, INotificationBuilder notificationBuilder)
  {
    notifyServices = new NotifyServices(ha);
    this.notificationBuilder = notificationBuilder;
    logUrl = config["Lerbaek:LogUrl"];
  }

  public void NotifyAppException(Exception e)
  {
    ((Action<MethodBase>)(mb =>
        notificationBuilder
          .SetTitle($"Fejl i {mb.DeclaringType!.Name}!")
          .SetMessage(e.Message)
          .SetColor(Red)
          .SetChannel("alert")
          .AddActionUri("Åbn log", ActionUri.Uri(logUrl!))
          .Notify(notifyServices.KristoffersTelefon)))
      .DoWithStackParent();
  }
}