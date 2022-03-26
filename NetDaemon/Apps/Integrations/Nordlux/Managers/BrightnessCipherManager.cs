using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Managers;

public class BrightnessCipherManager
{
  private readonly Brightness config;
  private readonly CipherManager cipherManager;

  public BrightnessCipherManager(Ciphers ciphersConfig, CipherManager cipherManager)
  {
    config = ciphersConfig.Brightness!;
    this.cipherManager = cipherManager;
  }

  public string Set(int percentage)
  {
    return percentage switch
    {
      <= 0 => cipherManager.State.Off,
      < 10 => BrightnessCipher(config.FirstDigit![percentage], config.SuffixOneDigit!),
      >= 100 => BrightnessCipher(config.FirstDigit![1], Suffix100),
      _ => BrightnessCipher(config.FirstDigit![percentage / 10] +
                            config.SecondDigit![percentage % 10], config.SuffixTwoDigits!)
    };
  }

  private string BrightnessCipher(string command, string suffix) => $"{cipherManager.PrefixSetter}{config.PostPrefix}{command}{suffix}";

  private string Suffix100 => config.PreSuffix100 + cipherManager.SuffixTemperatureOrMaxBrightness;
}