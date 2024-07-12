namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

public abstract class Con
{
  protected Con(string name, string value)
  {
    Name = name;
    Value = value;
  }

  public string Name { get; protected set; }
  public string Value { get; protected set; }
}