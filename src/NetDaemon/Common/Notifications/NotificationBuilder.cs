#pragma warning disable CS8618

using FluentValidation;
using Microsoft.Extensions.Configuration;

namespace Lerbaek.NetDaemon.Common.Notifications;

public class NotificationBuilder : VoiceNotificationBuilder, INotificationBuilder
{
  private IDictionary<string, string>[] _actions;
  public INotificationPresets Presets { get; }

  public string Title { get; private set; }

  public IDictionary<string, string>[] Actions
  {
    get => _actions;
    protected set
    {
      _actions = value;
      Data["actions"] = value;
    }
  }

  public NotificationBuilder(IHaContext ha, IConfiguration config, IValidator<VoiceNotificationBuilder> validator) : base(validator)
  {
    Presets = new NotificationPresets(ha, config, this);
  }

  public new INotificationBuilder Reset()
  {
    DoReset();
    return this;
  }

  protected override void DoReset()
  {
    base.DoReset();
    Message = null;
    Actions = Array.Empty<IDictionary<string, string>>();
  }

  public INotificationBuilder SetMessage(string message)
  {
    Message = message;
    return this;
  }

  public INotificationBuilder SetTitle(string title)
  {
    Title = title;
    return this;
  }

  public INotificationBuilder SetChannel(string channel)
  {
    Data["channel"] = channel;
    return this;
  }

  public INotificationBuilder SetColor(Color color)
  {
    Data["color"] = $"#{Convert.ToHexString(new[]{color.R, color.G, color.B})}";
    return this;
  }

  public INotificationBuilder SetIcon(Uri iconUrl) => SetIcon(iconUrl.AbsoluteUri);

  public INotificationBuilder SetIcon(string iconUrl)
  {
    Data["icon_url"] = iconUrl;
    return this;
  }

  public INotificationBuilder MakeSticky(bool isSticky = true)
  {
    Data["sticky"] = isSticky;
    return this;
  }

  public IVoiceNotificationBuilder MakeVoiceNotification(string ttsText, VoiceNotificationVolume voiceNotificationVolume)
  {
    base.Reset().SetTtsText(ttsText).SetVolume(voiceNotificationVolume);
    return this;
  }

  public override void Notify(params Action<string, string?, object?, object?>[] notifyActions)
  {
    DoNotify(notifyActions, Title);
    Reset();
  }

  public static void Clear(string tag, params Action<string, string?, object?, object?>[] notifyActions)
  {
    var data = new Dictionary<string, string> { { "tag", tag } };
    foreach (var notifyAction in notifyActions)
      notifyAction(
        "clear_notification",
        null,
        null,
        data);
  }

  public INotificationBuilder AddClickAction(ActionUri uri)
  {
    Data["clickAction"] = uri;
    return this;
  }

  public INotificationBuilder AddActionUri(string title, ActionUri uri, string? tag = null)
  {
    if (Actions.Length > 2)
      throw new NotSupportedException("Only 3 actions per notification are allowed");

    var action = new Dictionary<string, string>
    {
      { "action", "URI" },
      { "title", title },
      { "uri", uri }
    };

    if (tag != null)
      action.Add("tag", tag);

    Actions = Actions.Concat([action]).ToArray();
    return this;
  }

  public INotificationBuilder SetImage(Uri imageLink) => SetImage(imageLink.AbsoluteUri);

  public INotificationBuilder SetImage(string imageLink)
  {
    Data["image"] = imageLink;
    return this;
  }

  public INotificationBuilder SetTag(string tag)
  {
    Data["tag"] = tag;
    return this;
  }
}