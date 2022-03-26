using System.Drawing;

namespace Lerbaek.NetDaemon.Common.Notifications;

public interface INotificationBuilder
{
  string? Message { get; }
  string? Title { get; }
  IDictionary<string, object> Data { get; }
  IDictionary<string, string>[] Actions { get; }
  INotificationBuilder Reset();
  INotificationBuilder SetMessage(string message);
  INotificationBuilder SetTitle(string title);
  INotificationBuilder SetChannel(string channel);
  INotificationBuilder SetColor(Color color);
  INotificationBuilder MakeSticky(bool isSticky = true);
  IVoiceNotificationBuilder MakeVoiceNotification(string message, VoiceNotificationVolume voiceNotificationVolume);
  void Notify(params Action<string, string?, object?, object?>[] notifyActions);
  INotificationBuilder AddAction(string title, ActionUri uri, string? tag = null);
  INotificationBuilder SetImage(Uri imageLink);
  INotificationBuilder SetImage(string imageLink);
}