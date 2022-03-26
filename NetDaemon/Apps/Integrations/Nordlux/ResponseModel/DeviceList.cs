namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.ResponseModel;

public class DeviceList
{
  public int? isOnLine { get; set; }
  public int? cct { get; set; }
  public int? ringNum { get; set; }
  public int? bri { get; set; }
  public int? power { get; set; }
  public string? rgb { get; set; }
  public string? deviceId { get; set; }

  public bool IsOnline() => isOnLine == 1 && power == 1;
}