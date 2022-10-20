using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Managers;
using Lerbaek.NetDaemon.Common;
using Lerbaek.NetDaemon.Common.Converters;
using Lerbaek.NetDaemon.Common.Entities;
using Status = Lerbaek.NetDaemon.Apps.Integrations.Nordlux.ResponseModel.Status;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

/// <summary>
///   Application to control Nordlux lights.
/// </summary>
//[Focus]
[NetDaemonApp]
public class Nordlux : ServiceHandler
{
  private readonly IHomeAssistantApiManager apiManager;
  private readonly ILogger<Nordlux> logger;
  private readonly IRequestHandler requestHandler;
  private readonly CipherManager cipherManager;
  private readonly NordluxConfig config;

  public Nordlux(
    IHaContext haContext,
    IAppConfig<NordluxConfig> config,
    ILogger<Nordlux> logger,
    INetDaemonScheduler scheduler,
    IHomeAssistantApiManager apiManager,
    IRequestHandler requestHandler)
    : base(haContext, "olivetreebranch")
  {
    this.config = config.Value;
    this.logger = logger;
    this.apiManager = apiManager;
    this.requestHandler = requestHandler;

    cipherManager = new CipherManager(config.Value.Ciphers!);

    Initialize(scheduler);
  }

  private readonly (int, int) percentageRange = (1, 100);
  private readonly (int, int) byteRange = (1, 255);
  private readonly (int, int) temperatureRange = (153, 500);

  private void Initialize(INetDaemonScheduler scheduler)
  {
#pragma warning disable CS4014
    scheduler.RunEvery(FromMinutes(1), () => OliveTreeBranchGetStatus());

    RegisterService<Attributes>("setbrightness",       a => OliveTreeBranchSetBrightness      (a.brightness));
    RegisterService<Attributes>("setcolortemperature", a => OliveTreeBranchSetColorTemperature(a.temperature));
    
    RegisterService<State>("turnon",    OliveTreeBranchTurnOn);
    RegisterService<State>("turnoff",   OliveTreeBranchTurnOff);
    RegisterService<State>("getstatus", OliveTreeBranchGetStatus);

    OliveTreeBranchGetStatus();
#pragma warning restore CS4014
  }

  #region Records

  public record Attributes(int brightness, int temperature);

  public record State;

  #endregion

  #region Services

  public async Task OliveTreeBranchTurnOff()
  {
    LogServiceCall(logger, nameof(OliveTreeBranchTurnOff));
    await HandlerSetterService(nameof(OliveTreeBranchTurnOff), cipherManager.State.Off);
  }

  public async Task OliveTreeBranchTurnOn()
  {
    LogServiceCall(logger, nameof(OliveTreeBranchTurnOn));
    await HandlerSetterService(nameof(OliveTreeBranchTurnOn), cipherManager.State.On);
  }

  public async Task OliveTreeBranchSetBrightness(int brightness)
  {
    LogServiceCall(logger, nameof(OliveTreeBranchSetBrightness));
    var brightnessPercentage = brightness.ShiftRange(byteRange, percentageRange);
    await HandlerSetterService(nameof(OliveTreeBranchSetBrightness),
      cipherManager.Brightness.Set(brightnessPercentage), brightness);
  }

  /// <param name="temperature">Range: 153 (cold) - 500 (warm)</param>
  public async Task OliveTreeBranchSetColorTemperature(int temperature)
  {
    LogServiceCall(logger, nameof(OliveTreeBranchSetColorTemperature));
    var temperaturePercentage = temperature.ShiftRange(temperatureRange, percentageRange).Reverse(percentageRange);
    await HandlerSetterService(nameof(OliveTreeBranchSetColorTemperature),
      cipherManager.Temperature.Set(temperaturePercentage), temperature);
  }

  public async Task OliveTreeBranchGetStatus()
  {
    LogServiceCall(logger, nameof(OliveTreeBranchGetStatus));
    var status = await GetStatus();

    var deviceList = status.data!.deviceList;

    var entity = new LightEntities(haContext).OliveTreeBranch;

    var onlineDevices = deviceList!.Where(dl => dl.IsOnline()).ToArray();
    var isOnline = onlineDevices.Any();
    var state = isOnline
      ? "on"
      : "off";
    var attributes = entity.Attributes;
    if (isOnline && attributes is not null)
    {
      var brightness = ((int)onlineDevices.Average(d => d.bri)!).ShiftRange(percentageRange, byteRange);
      var temperature = ((int)onlineDevices.Average(d => d.cct)! % 100).ShiftRange(percentageRange, temperatureRange)
        .Reverse(temperatureRange);
      attributes = attributes.Set(brightness, colorTemp: new List<double>{temperature});
    }

    await apiManager.SetEntityStateAsync(entity.EntityId, state, attributes, CancellationToken.None);
  }

  private async Task HandlerSetterService(string serviceName, string commandCipher, params object[] args)
  {
    LogServiceCall(logger, serviceName, args);
    await requestHandler.Send(commandCipher);
    await OliveTreeBranchGetStatus();
  }


  private async Task<Status> GetStatus()
  {
    var statusCiphers = config.Ciphers!.Status!;
    var response = await requestHandler.Send(cipherManager.Base +
                                             cipherManager.CipherStatus +
                                             statusCiphers.Body +
                                             cipherManager.CipherStateOrGetStatus +
                                             statusCiphers.Suffix,
      RequestType.Get);
      
    var content = await response.Content.ReadAsStringAsync();
    logger.LogTrace("Status:{NewLine}{Content}", NewLine, content);
    return JsonConvert.DeserializeObject<Status>(content)!;
  }
  #endregion
}