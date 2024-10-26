using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;
using Lerbaek.NetDaemon.Common.Validation.Annotations;
using Version = System.Version;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

[ValidateConfig<NordluxConfig, NordluxConfigValidator>]
public class NordluxConfig
{
    public string SecretKey { get; set; } = string.Empty;
    public string AccessKey { get; set; } = string.Empty;
    public string AccountId { get; set; } = string.Empty;
    public string HouseId { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public string AppCode { get; set; } = string.Empty;
    public Version AppVersion { get; set; } = new(0, 0);
    public int BuildVersion { get; set; } = -1;
    public string MobileSystemType { get; set; } = string.Empty;
    public string UniqueIndication { get; set; } = string.Empty;
    public ApiVersions ApiVersions { get; set; } = new();
}