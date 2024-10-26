using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;
using Lerbaek.NetDaemon.Common.Validation;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;

public class ControlValidator : AbstractValidatorExtended<Control>
{
    private ControlValidator()
    {
        foreach (var ruleBuilder in RuleForMany(
                 [
                     x => x.Name,
                     x => x.Value,

                 ]))
        {
            ruleBuilder.NotEmpty();
        }

        RuleFor(x => x.Model).GreaterThanOrEqualTo(0);
    }

    public static ControlValidator Instance { get; } = new();
}