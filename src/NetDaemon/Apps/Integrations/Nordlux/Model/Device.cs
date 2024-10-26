using System.Text.Json.Serialization;
using Lerbaek.NetDaemon.Common.Converters.Json;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

public record Device : DeviceSetter
{
    [JsonPropertyName("isOnLine")]
    [System.Text.Json.Serialization.JsonConverter(typeof(BoolToIntConverter))]
    public bool IsOnline { get; init; }

    [JsonPropertyName("lowPowerFlag")]
    [System.Text.Json.Serialization.JsonConverter(typeof(BoolToIntConverter))]
    public bool LowPowerFlag { get; init; }

    [JsonPropertyName("thingType")]
    public ThingType ThingType { get; init; }
}