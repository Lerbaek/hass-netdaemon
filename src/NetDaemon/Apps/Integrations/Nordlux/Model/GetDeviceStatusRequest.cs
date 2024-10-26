using System.Text.Json.Serialization;
using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

public record GetDeviceStatusRequest : RequestBase
{
    public GetDeviceStatusRequest(NordluxConfig config) : base(config)
    {
        HouseId = config.HouseId;
        UniqueIndication = config.UniqueIndication;
        Version = config.ApiVersions.GetDeviceStatus;
    }

    [JsonPropertyName("houseId")]
    public string HouseId { get; init; } = string.Empty;

    [JsonPropertyName("uniqueIndication")]
    public string UniqueIndication { get; init; } = string.Empty;

    public override void OnSerializing()
    {
        GetDeviceStatusValidator.Instance.ValidateAndThrow(this);
    }
}