#pragma warning disable CS8618

using FluentValidation;

namespace Lerbaek.NetDaemon.Common.Notifications;

public class VoiceNotificationBuilder : IVoiceNotificationBuilder
{
  protected readonly IValidator<VoiceNotificationBuilder> Validator;
  public string? Message { get; protected set; }
  public string? Title { get; protected set; }
  public IDictionary<string, object> Data { get; protected set; }

  protected VoiceNotificationBuilder(IValidator<VoiceNotificationBuilder> validator)
  {
    Validator = validator;
    // ReSharper disable once VirtualMemberCallInConstructor
    DoReset();
  }

  protected virtual void DoReset()
  {
    Title = null;
    Data = new Dictionary<string, object>();
  }

  public IVoiceNotificationBuilder Reset()
  {
    DoReset();
    Message = "TTS";
    return this;
  }

  protected void DoSetTitle(string title) => Title = title;

  public IVoiceNotificationBuilder SetTitle(string title)
  {
    DoSetTitle(title);
    return this;
  }

  public IVoiceNotificationBuilder SetVolume(VoiceNotificationVolume voiceNotificationVolume)
  {
    DoSetVolume(voiceNotificationVolume);
    return this;
  }

  protected void DoSetVolume(VoiceNotificationVolume voiceNotificationVolume)
  {
    if (voiceNotificationVolume == VoiceNotificationVolume.Default)
    {
      if (Data.ContainsKey("channel"))
        Data.Remove("channel");
      return;
    }

    // ReSharper disable once SwitchExpressionHandlesSomeKnownEnumValuesWithExceptionInDefault
    Data["channel"] = voiceNotificationVolume switch
    {
      VoiceNotificationVolume.NotZero => "alarm_stream",
      VoiceNotificationVolume.Max => "alarm_stream_max",
      _ => throw new ArgumentException($"{nameof(VoiceNotificationVolume)} value '{(int)voiceNotificationVolume}' not supported",
        nameof(voiceNotificationVolume))
    };
  }

  public virtual void Notify(params Action<string, string?, object?, object?>[] notifyActions)
  {
    DoNotify(notifyActions);
    Reset();
  }

  protected void DoNotify(Action<string, string?, object?, object?>[] notifyActions)
  {
    Validator.ValidateAndThrow(this);

    foreach (var notifyAction in notifyActions)
    {
      notifyAction(
        Message!,
        Title,
        null,
        Data
      );
    }
  }
}