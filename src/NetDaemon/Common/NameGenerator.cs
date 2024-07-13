namespace Lerbaek.NetDaemon.Common;

public class NameGenerator(string prefix)
{
  public string Prefix { get; } = prefix;

  public string Service(string serviceName) => $"{Prefix}_{serviceName}";
}