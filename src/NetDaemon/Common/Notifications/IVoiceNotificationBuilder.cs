namespace Lerbaek.NetDaemon.Common.Notifications;

public interface IVoiceNotificationBuilder
{
  string? Message { get; }
  IDictionary<string, object> Data { get; }
  IVoiceNotificationBuilder Reset();
  IVoiceNotificationBuilder SetTtsText(string stsText);
  IVoiceNotificationBuilder SetVolume(VoiceNotificationVolume voiceNotificationVolume);
  void Notify(params Action<string, string?, object?, object?>[] notifyActions);
}