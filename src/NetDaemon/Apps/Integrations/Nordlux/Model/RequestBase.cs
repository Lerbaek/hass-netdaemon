using System.Text.Json.Serialization;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Common.Converters.Json;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

public abstract record RequestBase : IJsonOnSerializing
{
    protected NordluxConfig Config { get; }

    protected RequestBase(NordluxConfig config)
    {
        Config = config;
        AccountId = config.AccountId;
        Token = config.Token;
        AppCode = config.AppCode;
        AppVersion = config.AppVersion;
        BuildVersion = config.BuildVersion;
        MobileSystemType = config.MobileSystemType;
    }

    [JsonPropertyName("accountId")]
    public string AccountId { get; init; } = string.Empty;

    [JsonPropertyName("token")]
    public string Token { get; init; } = string.Empty;

    [JsonPropertyName("appCode")]
    public string AppCode { get; init; } = string.Empty;

    [System.Text.Json.Serialization.JsonConverter(typeof(VersionConverter))]
    [JsonPropertyName("appVersion")]
    public Version AppVersion { get; init; } = new(0, 0);

    [JsonPropertyName("build_v")]
    public int BuildVersion { get; init; } = -1;

    [JsonPropertyName("mobileSystemType")]
    public string MobileSystemType { get; init; } = string.Empty;

    [System.Text.Json.Serialization.JsonConverter(typeof(VersionConverter))]
    [JsonPropertyName("version")]
    public Version Version { get; init; } = new(0,0);

    /// <inheritdoc/>
    /// <remarks>
    /// Used for implicit validation.
    /// </remarks>
    public abstract void OnSerializing();
}