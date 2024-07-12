using System.Collections.ObjectModel;

namespace Lerbaek.NetDaemon.Common.Notifications;

public static class Configuration
{
  public const string TtsTextKey = "tts_text";
  public const string MediaStreamKey = "media_stream";
  public const string Tts = "TTS";

  public static ReadOnlyDictionary<VoiceNotificationVolume, string> VoiceNotificationVolumeStream =
    new(new Dictionary<VoiceNotificationVolume, string>
    {
      { VoiceNotificationVolume.NotZero, "alarm_stream" },
      { VoiceNotificationVolume.Max, "alarm_stream_max" }
    });
}