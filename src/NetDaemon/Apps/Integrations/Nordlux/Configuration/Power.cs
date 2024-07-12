namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

public class Power : Con
{

  private Power(State value) : base("cct", $"{(int)value}") {}

  public static Power Off => new(State.Off);
  public static Power On => new(State.On);

  public enum State
  {
    On = 10000,
    Off = 15000
  }
}