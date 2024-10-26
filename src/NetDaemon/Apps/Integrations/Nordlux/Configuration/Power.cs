namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

public class Power : Configuration
{
    private Power(State value) : base("cct", $"{(int)value}") { }

    public static Power Off => new(State.Off);
    public static Power On => new(State.On);

    private enum State
    {
        On = 10000,
        Off = 15000
    }
}