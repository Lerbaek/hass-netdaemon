namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

public class Temperature : Con
{

  private Temperature(int value) : base("cct", $"{value}") {}

  public static Temperature WithValue(int value)
  {
    if (value is < 1 or > 100)
      throw new ArgumentOutOfRangeException(nameof(value));
    return new Temperature(800 + value);
  }
}