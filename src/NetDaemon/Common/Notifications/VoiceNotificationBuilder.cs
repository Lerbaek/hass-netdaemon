#pragma warning disable CS8618

using FluentValidation;
using static Lerbaek.NetDaemon.Common.Notifications.Configuration;

namespace Lerbaek.NetDaemon.Common.Notifications;

public class VoiceNotificationBuilder : IVoiceNotificationBuilder
{
  protected readonly IValidator<VoiceNotificationBuilder> Validator;
  public string? Message { get; protected set; }
  public string? Volume { get; protected set; }
  public IDictionary<string, object> Data { get; protected set; }

  protected VoiceNotificationBuilder(IValidator<VoiceNotificationBuilder> validator)
  {
    Validator = validator;
    // ReSharper disable once VirtualMemberCallInConstructor
    DoReset();
  }

  protected virtual void DoReset()
  {
    Data = new Dictionary<string, object>();
  }

  public IVoiceNotificationBuilder Reset()
  {
    DoReset();
    Message = Tts;
    return this;
  }

  public IVoiceNotificationBuilder SetTtsText(string stsText)
  {
    Data[TtsTextKey] = stsText;
    return this;
  }

  public IVoiceNotificationBuilder SetVolume(VoiceNotificationVolume voiceNotificationVolume)
  {
    if (voiceNotificationVolume == VoiceNotificationVolume.Default)
    {
      if (Data.ContainsKey(MediaStreamKey))
        Data.Remove(MediaStreamKey);
    }
    else
    {
      if (!VoiceNotificationVolumeStream.ContainsKey(voiceNotificationVolume))
        throw new ArgumentException(
          $@"{nameof(VoiceNotificationVolume)} value '{(int)voiceNotificationVolume}' not supported",
          nameof(voiceNotificationVolume));
      Data[MediaStreamKey] = VoiceNotificationVolumeStream[voiceNotificationVolume];
    }

    // ReSharper disable once SwitchExpressionHandlesSomeKnownEnumValuesWithExceptionInDefault
    return this;
  }

  public virtual void Notify(params Action<string, string?, object?, object?>[] notifyActions)
  {
    DoNotify(notifyActions);
    Reset();
  }

  protected void DoNotify(Action<string, string?, object?, object?>[] notifyActions, string? title = null)
  {
    Validator.ValidateAndThrow(this);

    foreach (var notifyAction in notifyActions)
    {
      notifyAction(
        Message!,
        title,
        null,
        Data
      );
    }
  }
}