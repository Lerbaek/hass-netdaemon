namespace Lerbaek.NetDaemon.Common.Notifications;

public interface IVoiceNotificationBuilder
{
  string? Message { get; }
  string? Title { get; }
  IDictionary<string, object> Data { get; }
  IVoiceNotificationBuilder Reset();
  IVoiceNotificationBuilder SetTitle(string title);
  IVoiceNotificationBuilder SetVolume(VoiceNotificationVolume voiceNotificationVolume);
  void Notify(params Action<string, string?, object?, object?>[] notifyActions);
}