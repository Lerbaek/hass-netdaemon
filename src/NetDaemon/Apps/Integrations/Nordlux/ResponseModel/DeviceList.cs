namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.ResponseModel;

public class DeviceList
{
  public int? IsOnLine { get; set; }
  public int? Cct { get; set; }
  public int? RingNum { get; set; }
  public int? Bri { get; set; }
  public int? Power { get; set; }
  public string? Rgb { get; set; }
  public string? DeviceId { get; set; }

  public bool IsOnline() => IsOnLine == 1 && Power == 1;
}