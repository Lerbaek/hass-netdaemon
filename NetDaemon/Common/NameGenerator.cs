namespace Lerbaek.NetDaemon.Common;

public class NameGenerator
{
  public string Prefix { get; }

  public NameGenerator(string prefix) => Prefix = prefix;

  public string Service(string serviceName) => $"{Prefix}_{serviceName}";
}