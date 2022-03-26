namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

public class Ciphers
{
  public Brightness? Brightness { get; set; }
  public Temperature? Temperature { get; set; }
  public string? Base { get; set; }
  public string? Setter { get; set; }
  public string? PostSetter { get; set; }
  public string? StateOrTemperatureSetter { get; set; }
  public string? TemperatureOrMaxBrightness { get; set; }
  public Status? Status { get; set; }
  public State? State { get; set; }
  public string? StateOrGetStatus { get; set; }
}