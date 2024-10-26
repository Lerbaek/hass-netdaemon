using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;

public class StatusValidator : AbstractValidator<RequestBase>
{
    private StatusValidator()
    {
        RuleFor(x => x.AccountId).NotEmpty();
        RuleFor(x => x.Token).NotEmpty();
        RuleFor(x => x.AppCode).NotEmpty();
        RuleFor(x => x.AppVersion).NotEmpty();
        RuleFor(x => x.BuildVersion).GreaterThan(0);
        RuleFor(x => x.MobileSystemType).NotEmpty();
        RuleFor(x => x.Version).NotEmpty();
    }

    public static StatusValidator Instance { get; } = new();
}