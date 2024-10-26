using System.Text.Json.Serialization;
using Lerbaek.NetDaemon.Common.Converters.Json;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.ResponseModel;

public record Status(
    [property: JsonPropertyName("msg")]
    string Message,

    [property: JsonPropertyName("data")]
    Data Data,

    [property: JsonPropertyName("isSuccess")]
    [property: System.Text.Json.Serialization.JsonConverter(typeof(BoolToIntConverter))]
    bool IsSuccess);