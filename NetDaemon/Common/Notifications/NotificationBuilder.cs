#pragma warning disable CS8618

using System.Drawing;
using FluentValidation;

namespace Lerbaek.NetDaemon.Common.Notifications;

public class NotificationBuilder : VoiceNotificationBuilder, INotificationBuilder
{
  public IDictionary<string, string>[] Actions { get; protected set; }

  public NotificationBuilder(IValidator<VoiceNotificationBuilder> validator) : base(validator)
  {
  }

  public new INotificationBuilder Reset()
  {
    DoReset();
    return this;
  }

  private new void DoReset()
  {
    Message = null;
    Actions = Array.Empty<IDictionary<string, string>>();
    base.DoReset();
  }

  public INotificationBuilder SetMessage(string message)
  {
    Message = message;
    return this;
  }

  public new INotificationBuilder SetTitle(string title)
  {
    DoSetTitle(title);
    return this;
  }

  public INotificationBuilder SetChannel(string channel)
  {
    Data["channel"] = channel;
    return this;
  }

  public INotificationBuilder SetColor(Color color)
  {
    Data["color"] = $"#{color.Name[2..]}";
    return this;
  }

  public INotificationBuilder MakeSticky(bool isSticky = true)
  {
    Data["sticky"] = isSticky;
    return this;
  }

  public IVoiceNotificationBuilder MakeVoiceNotification(string message, VoiceNotificationVolume voiceNotificationVolume)
  {
    base.Reset().SetTitle(message).SetVolume(voiceNotificationVolume);
    return this;
  }

  public override void Notify(params Action<string, string?, object?, object?>[] notifyActions)
  {
    DoNotify(notifyActions);
    Reset();
  }
  
  public INotificationBuilder AddAction(string title, ActionUri uri, string? tag = null)
  {
    if (!Data.ContainsKey("actions"))
      Data.Add("actions", Actions);
    else if (Actions.Length > 2)
      throw new NotSupportedException("Only 3 actions per notification are allowed");

    var action = new Dictionary<string, string>
    {
      { "action", "URI" },
      { "title", title },
      { "uri", uri }
    };

    if (tag != null)
      action.Add("tag", tag);

    Actions = Actions.Concat(new[] { action }).ToArray();
    return this;
  }

  public INotificationBuilder SetImage(Uri imageLink)
  {
    return SetImage(imageLink.AbsoluteUri);
  }

  public INotificationBuilder SetImage(string imageLink)
  {
    Data["image"] = imageLink;
    return this;
  }
}