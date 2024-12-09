namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

public static class ApiServiceConstants
{
    /// <summary>
    /// For reporting the status of bulbs after local changes.
    /// </summary>
    public const string ReportBulbStatus = "reportBulbStatus";

    /// <summary>
    /// For getting the status of devices.
    /// </summary>
    public const string GetDeviceStatus = "getDeviceStatus";

    /// <summary>
    /// For controlling a BLE device through a gateway.
    /// </summary>
    public const string ControllerBle = "controllerBLE";
}