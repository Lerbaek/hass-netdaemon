using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Managers;

public class TemperatureCipherManager
{
  private readonly CipherManager cipherManager;
  private readonly Temperature config;

  public TemperatureCipherManager(Ciphers cipherConfig, CipherManager cipherManager)
  {
    config = cipherConfig.Temperature!;
    this.cipherManager = cipherManager;
  }

  public string Set(int percentage)
  {
    return percentage switch
    {
      <= 0 or > 100 => TemperatureCipher(config.Digits![20]),
      100 => TemperatureCipher(config.Digits![percentage]),
      _ => TemperatureCipher(config.Under100PostPrefix + config.Digits![percentage])
    };
  }
  private string TemperatureCipher(string command) => cipherManager.PrefixStateOrTemperatureSetter +
                                                      command +
                                                      cipherManager.SuffixTemperatureOrMaxBrightness;
}