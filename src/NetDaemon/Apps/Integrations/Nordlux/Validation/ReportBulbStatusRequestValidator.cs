using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;

public class ReportBulbStatusRequestValidator : AbstractValidator<ReportBulbStatusRequest>
{
    private ReportBulbStatusRequestValidator()
    {
        Include(StatusValidator.Instance);
        RuleFor(x => x.DeviceList).NotEmpty();
        RuleForEach(x => x.DeviceList).SetValidator(DeviceSetterValidator.Instance);
    }

    public static ReportBulbStatusRequestValidator Instance { get; } = new();
}