using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Managers;

public class CipherManager
{
  private readonly Ciphers config;
  public BrightnessCipherManager Brightness { get; }
  public TemperatureCipherManager Temperature { get; }
  public StateCipherManager State { get; }

  public CipherManager(Ciphers config)
  {
    this.config = config;
    Brightness = new BrightnessCipherManager(config, this);
    Temperature = new TemperatureCipherManager(config, this);
    State = new StateCipherManager(config, this);
  }

  public string Base => config.Base!;
  public string PrefixSetter => Base +
                                config.Setter +
                                CipherStatus +
                                config.PostSetter;
  public string PrefixStateOrTemperatureSetter => PrefixSetter +
                                                  config.StateOrTemperatureSetter;
  public string SuffixTemperatureOrMaxBrightness => config.TemperatureOrMaxBrightness!;
  public string CipherStatus => config.Status!.PrefixBody!;
  public string CipherStateOrGetStatus => config.StateOrGetStatus!;
}