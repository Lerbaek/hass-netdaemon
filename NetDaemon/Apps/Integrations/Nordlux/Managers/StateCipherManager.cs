using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Managers;

public class StateCipherManager
{
  private readonly Ciphers config;
  private readonly CipherManager cipherManager;

  public StateCipherManager(Ciphers config, CipherManager cipherManager)
  {
    this.config = config;
    this.cipherManager = cipherManager;
  }

  private string OnOffCipher(string command) => cipherManager.PrefixStateOrTemperatureSetter +
                                                config.State!.PrefixCommand + 
                                                command +
                                                config.State.SuffixCommand +
                                                cipherManager.CipherStateOrGetStatus +
                                                config.State.Suffix;

  public string On => OnOffCipher(config.State!.On!);
  public string Off => OnOffCipher(config.State!.Off!);
}