using static System.ArgumentOutOfRangeException;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

public class Brightness : Con
{
    public Brightness(int value) : base("bri", $"{value}")
    {
        ThrowIfNegativeOrZero(value, nameof(value));
        ThrowIfGreaterThan(100, value, nameof(value));
    }
}