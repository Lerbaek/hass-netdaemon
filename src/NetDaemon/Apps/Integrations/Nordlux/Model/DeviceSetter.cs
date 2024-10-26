using System.Text.Json.Serialization;
using Lerbaek.NetDaemon.Common.Converters.Json;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

public record DeviceSetter
{
    [JsonPropertyName("bri")]
    public required int Brightness { get; init; } = -1;

    [JsonPropertyName("cct")]
    [System.Text.Json.Serialization.JsonConverter(typeof(PercentageToTemperatureConverter))]
    public int Temperature { get; init; } = -1;

    [JsonPropertyName("deviceId")]
    public string DeviceId { get; init; } = string.Empty;

    [JsonPropertyName("power")]
    [System.Text.Json.Serialization.JsonConverter(typeof(BoolToIntConverter))]
    public bool Power { get; init; }

    [JsonPropertyName("rgb")]
    public string Colour { get; init; } = string.Empty;

    [JsonPropertyName("ringNum")]
    public int RingNumber { get; init; } = -1;
}