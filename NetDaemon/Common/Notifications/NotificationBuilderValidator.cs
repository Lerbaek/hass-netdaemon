using FluentValidation;

namespace Lerbaek.NetDaemon.Common.Notifications;

public class NotificationBuilderValidator : AbstractValidator<VoiceNotificationBuilder>
{
  public NotificationBuilderValidator()
  {
    RuleFor(nb => nb.Title)
      .NotNull()
      .NotEmpty()
      .WithMessage($"Notification is missing {nameof(NotificationBuilder.Title)}");
    RuleFor(nb => nb.Message)
      .NotNull()
      .NotEmpty()
      .WithMessage($"Notification is missing {nameof(NotificationBuilder.Message)}");
    RuleFor(nb => nb.Message)
      .Equal("TTS")
      .When(nb => nb is not NotificationBuilder)
      .WithMessage($"In a non-inherited {nameof(VoiceNotificationBuilder)}, the value of {nameof(VoiceNotificationBuilder.Message)} must always be \"TTS\"");
  }
}