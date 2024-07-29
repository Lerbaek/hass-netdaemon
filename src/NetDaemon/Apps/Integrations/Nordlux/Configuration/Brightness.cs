using static System.ArgumentOutOfRangeException;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

public class Brightness : Con
{

  private Brightness(int value) : base("bri", $"{value}") {}

  public static Brightness WithValue(int value)
  {
    ThrowIfNegativeOrZero(value, nameof(value));
    ThrowIfGreaterThan(100, value, nameof(value));
    return new Brightness(value);
  }
}