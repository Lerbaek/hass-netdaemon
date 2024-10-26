using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;
using Lerbaek.NetDaemon.Common.Validation;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;

public class ControllerBleRequestValidator : AbstractValidatorExtended<ControllerBleRequestBase>
{
    private ControllerBleRequestValidator()
    {
        Include(StatusValidator.Instance);
        foreach (var ruleBuilder in RuleForMany(
                 [
                     x => x.HouseId,
                     x => x.TargetId
                 ]))
        {
            ruleBuilder.NotEmpty();
        }

        foreach (var ruleBuilder in RuleForMany(
                 [
                     x => x.AddressType,
                     x => x.AppKeyIndex,
                     x => x.ControlAddress,
                     x => x.ElemIndex,
                     x => x.RoomCode,
                     x => x.TargetType,
                     x => x.Type,
                     x => x.Uv,
                     x => x.BuildVersion

                 ]))
        {
            ruleBuilder.GreaterThanOrEqualTo(0);
        }
    }

    public static ControllerBleRequestValidator Instance { get; } = new();
}