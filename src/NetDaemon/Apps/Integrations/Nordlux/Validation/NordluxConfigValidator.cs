using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Common.Validation;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;

public class NordluxConfigValidator : AbstractOptionsValidatorExtended<NordluxConfig>
{
    public NordluxConfigValidator()
    {
        foreach (var ruleBuilder in RuleForMany(
                 [
                     x => x.SecretKey,
                     x => x.AccessKey,
                     x => x.AccountId,
                     x => x.HouseId,
                     x => x.Token,
                     x => x.AppCode,
                     x => x.MobileSystemType,
                     x => x.UniqueIndication,
                 ]))
        {
            ruleBuilder.NotEmpty();
        }

        RuleFor(x => x.AppVersion).GreaterThanZero();
        RuleFor(x => x.ApiVersions).NotNull().DependentRules(() =>
        {
            RuleForMany(
            [
                x => x.ApiVersions.ControllerBle,
                x => x.ApiVersions.GetDeviceStatus,
                x => x.ApiVersions.ReportBulbRequest
            ]).GreaterThanZero();
        });
        RuleFor(x => x.BuildVersion).GreaterThan(0);
    }
}