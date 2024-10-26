namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

public class ApiVersions
{
    public Version GetDeviceStatus { get; set; } = new(0, 0);
    public Version ReportBulbRequest { get; set; } = new(0, 0);
    public Version ControllerBle { get; set; } = new(0, 0);
}