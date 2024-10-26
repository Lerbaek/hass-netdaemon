using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;

public class DeviceSetterValidator : AbstractValidator<DeviceSetter>
{
    private DeviceSetterValidator()
    {
        RuleFor(x => x.DeviceId).NotEmpty();
        RuleFor(x => x.Brightness).InclusiveBetween(1, 100);
        RuleFor(x => x.Colour).Matches("^$|^[A-Fa-f0-9]{6}$");
        RuleFor(x => x.Temperature).InclusiveBetween(1, 100);
        RuleFor(x => x.RingNumber).GreaterThan(0);
        RuleFor(x => x.Power).NotNull();
    }

    public static DeviceSetterValidator Instance { get; } = new();
}