using System.Text.Json.Serialization;
using Device = Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model.Device;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.ResponseModel;

public record Data(
    [property: JsonPropertyName("deviceList")]
    IEnumerable<Device> DeviceList);