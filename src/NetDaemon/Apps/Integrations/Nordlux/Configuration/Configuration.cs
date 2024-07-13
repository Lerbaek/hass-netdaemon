namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

public abstract class Con(string name, string value)
{
  public string Name { get; protected set; } = name;
  public string Value { get; protected set; } = value;
}