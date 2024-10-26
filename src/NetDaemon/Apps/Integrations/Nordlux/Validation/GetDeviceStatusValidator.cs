using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;

public class GetDeviceStatusValidator : AbstractValidator<GetDeviceStatusRequest>
{
    private GetDeviceStatusValidator()
    {
        Include(StatusValidator.Instance);
        RuleFor(x => x.HouseId).NotEmpty();
        RuleFor(x => x.UniqueIndication).NotEmpty();
    }

    public static GetDeviceStatusValidator Instance { get; } = new();
}