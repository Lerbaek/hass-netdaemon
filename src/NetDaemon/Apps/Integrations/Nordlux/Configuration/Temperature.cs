using static System.ArgumentOutOfRangeException;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

public class Temperature : Configuration
{

    public Temperature(int value) : base("cct", $"{800 + value}")
    {
        ThrowIfNegativeOrZero(value, nameof(value));
        ThrowIfGreaterThan(100, value, nameof(value));
    }
}