using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

public record ReportBulbStatusRequest : RequestBase
{
    public IEnumerable<DeviceSetter> DeviceList { get; init; }

    public ReportBulbStatusRequest(NordluxConfig config, IEnumerable<DeviceSetter> deviceList) : base(config)
    {
        DeviceList = deviceList;
        Version = config.ApiVersions.ControllerBle;
    }

    public override void OnSerializing()
    {
        ReportBulbStatusRequestValidator.Instance.ValidateAndThrow(this);
    }
}