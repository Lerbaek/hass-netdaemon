namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

public class Brightness : Con
{

  private Brightness(int value) : base("bri", $"{value}") {}

  public static Brightness WithValue(int value)
  {
    if (value is < 1 or > 100)
      throw new ArgumentOutOfRangeException(nameof(value));
    return new Brightness(value);
  }
}