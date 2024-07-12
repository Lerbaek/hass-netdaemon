namespace Lerbaek.NetDaemon.Common.Notifications;

public interface INotificationBuilder
{
  INotificationPresets Presets { get; }
  string? Message { get; }
  string? Title { get; }
  IDictionary<string, object> Data { get; }
  IDictionary<string, string>[] Actions { get; }
  INotificationBuilder Reset();
  INotificationBuilder SetMessage(string message);
  INotificationBuilder SetTitle(string title);
  INotificationBuilder SetChannel(string channel);
  INotificationBuilder SetColor(Color color);
  INotificationBuilder SetIcon(Uri iconUrl);
  INotificationBuilder SetIcon(string iconUrl);
  INotificationBuilder MakeSticky(bool isSticky = true);
  IVoiceNotificationBuilder MakeVoiceNotification(string ttsText, VoiceNotificationVolume voiceNotificationVolume);
  void Notify(params Action<string, string?, object?, object?>[] notifyActions);
  INotificationBuilder AddClickAction(ActionUri uri);
  INotificationBuilder AddActionUri(string title, ActionUri uri, string? tag = null);
  INotificationBuilder SetImage(Uri imageLink);
  INotificationBuilder SetImage(string imageLink);
  INotificationBuilder SetTag(string tag);
}