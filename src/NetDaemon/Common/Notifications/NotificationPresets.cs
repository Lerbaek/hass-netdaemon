using Lerbaek.NetDaemon.Common.Logging;
using Microsoft.Extensions.Configuration;

namespace Lerbaek.NetDaemon.Common.Notifications;

public class NotificationPresets(IHaContext ha, IConfiguration config, INotificationBuilder notificationBuilder)
  : INotificationPresets
{
  private readonly string _logUrl = config["Lerbaek:LogUrl"];
  private readonly NotifyServices _notifyServices = new(ha);

  public void NotifyAppException(Exception e)
  {
    ((Action<MethodBase>)(mb =>
        notificationBuilder
          .SetTitle($"Fejl i {mb.DeclaringType!.Name}!")
          .SetMessage(e.Message)
          .SetColor(Red)
          .SetChannel("alert")
          .AddActionUri("Åbn log", ActionUri.Uri(_logUrl!))
          .Notify(_notifyServices.KristoffersTelefon)))
      .DoWithStackParent();
  }
}