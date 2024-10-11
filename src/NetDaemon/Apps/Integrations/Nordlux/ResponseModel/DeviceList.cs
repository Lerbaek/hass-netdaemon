namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.ResponseModel;

public record DeviceList(
    int? IsOnLine,
    int? Cct,
    int? RingNum,
    int? Bri,
    int? Power,
    string? Rgb,
    string? DeviceId)
{
    public bool IsOnline() => IsOnLine == 1 && Power == 1;
}