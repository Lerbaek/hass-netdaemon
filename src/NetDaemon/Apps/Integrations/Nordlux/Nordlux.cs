using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
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

    Initialize(scheduler);
  }

  private readonly (int, int) percentageRange = (1, 100);
  private readonly (int, int) byteRange = (1, 255);
  private readonly (int, int) temperatureRange = (153, 500);

  private void Initialize(INetDaemonScheduler scheduler)
  {
#pragma warning disable CS4014
    scheduler.RunEvery(FromMinutes(1), () => OliveTreeBranchGetStatus());

    RegisterService<Attributes>("setbrightness",       a => OliveTreeBranchSetBrightness      (a.Brightness));
    RegisterService<Attributes>("setcolortemperature", a => OliveTreeBranchSetColorTemperature(a.Temperature));
    
    RegisterService<State>("turnon",    OliveTreeBranchTurnOn);
    RegisterService<State>("turnoff",   OliveTreeBranchTurnOff);
    RegisterService<State>("getstatus", OliveTreeBranchGetStatus);

    OliveTreeBranchGetStatus();
#pragma warning restore CS4014
  }

  #region Records

  public record Attributes(int Brightness, int Temperature);

  public record State;

  #endregion

  #region Services

  public async Task OliveTreeBranchTurnOff()
  {
    LogServiceCall(logger, nameof(OliveTreeBranchTurnOff));
    await HandlerSetterService(nameof(OliveTreeBranchTurnOff), Power.Off);
  }

  public async Task OliveTreeBranchTurnOn()
  {
    LogServiceCall(logger, nameof(OliveTreeBranchTurnOn));
    await HandlerSetterService(nameof(OliveTreeBranchTurnOn), Power.On);
  }

  public async Task OliveTreeBranchSetBrightness(int brightness)
  {
    LogServiceCall(logger, nameof(OliveTreeBranchSetBrightness));
    var brightnessPercentage = brightness.ShiftRange(byteRange, percentageRange);
    await HandlerSetterService(nameof(OliveTreeBranchSetBrightness), Brightness.WithValue(brightnessPercentage));
  }

  /// <param name="temperature">Range: 153 (cold) - 500 (warm)</param>
  public async Task OliveTreeBranchSetColorTemperature(int temperature)
  {
    LogServiceCall(logger, nameof(OliveTreeBranchSetColorTemperature));
    var temperaturePercentage = temperature.ShiftRange(temperatureRange, percentageRange).Reverse(percentageRange);
    await HandlerSetterService(nameof(OliveTreeBranchSetColorTemperature), Temperature.WithValue(temperaturePercentage));
  }

  public async Task OliveTreeBranchGetStatus()
  {
    LogServiceCall(logger, nameof(OliveTreeBranchGetStatus));
    var status = await GetStatus();

    var deviceList = status.Data!.DeviceList!.ToArray();

    if (!deviceList.Any())
    {
      logger.LogWarning("No devices were found when retrieving status. Assert that the ciphers are still valid.");
      return;
    }

    var entity = new LightEntities(HaContext).OliveTreeBranch;

    var onlineDevices = deviceList.Where(dl => dl.IsOnline()).ToArray();
    var isOnline = onlineDevices.Any();
    var state = isOnline
      ? "on"
      : "off";
    var attributes = entity.Attributes;
    if (isOnline && attributes is not null)
    {
      var brightness = ((int)onlineDevices.Average(d => d.Bri)!).ShiftRange(percentageRange, byteRange);
      var temperature = ((int)onlineDevices.Average(d => d.Cct)! % 100).ShiftRange(percentageRange, temperatureRange)
        .Reverse(temperatureRange);
      attributes = attributes.Set(brightness, colorTemp: temperature);
    }

    await apiManager.SetEntityStateAsync(entity.EntityId, state, attributes, CancellationToken.None);
  }

  private async Task HandlerSetterService(string serviceName, Con con)
  {
    var setStatusBody =
      $$"""
      {
          "accountId": "{{config.AccountId}}",
          "addressType": 1,
          "appkeyIndex": 0,
          "conAddress": 49152,
          "conList": [
              {
                  "conModel": 4867,
                  "conName": "{{con.Name}}",
                  "conValue": "{{con.Value}}"
              }
          ],
          "elemIndex": 0,
          "houseId": "{{config.HouseId}}",
          "roomCode": 1,
          "targetId": "54fdcc619d9b4f37848edc6da6ea156b",
          "targetType": 2,
          "token": "{{config.Token}}",
          "type": 1,
          "uv": 0,
          "appCode": "{{config.AppCode}}",
          "appVersion": "{{config.AppVersion}}",
          "bulid_v": {{config.BulidV}},
          "mobileSystemType": "{{config.MobileSystemType}}",
          "version": "{{config.Version}}"
      }
      """;
    LogServiceCall(logger, serviceName);
    await requestHandler.Send(setStatusBody);
    await OliveTreeBranchGetStatus();
  }

  private async Task<Status> GetStatus()
  {
    try
    {
      var getStatusBody =
        $$"""
          {
            "accountId":"{{config.AccountId}}",
            "houseId":"{{config.HouseId}}",
            "token":"{{config.Token}}",
            "appCode":"{{config.AppCode}}",
            "appVersion":"{{config.AppVersion}}",
            "bulid_v":{{config.BulidV}},
            "mobileSystemType":"{{config.MobileSystemType}}",
            "uniqueIndication":"{{config.UniqueIndication}}",
            "version":"{{config.Version}}"
          }
          """;

      var response = await requestHandler.Send(
        getStatusBody,
        ApiPath.GetBulbStatus);
      
      var content = await response.Content.ReadAsStringAsync();
      logger.LogTrace("Status:{NewLine}{Content}", NewLine, content);
      return JsonConvert.DeserializeObject<Status>(content)!;
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
  }
  #endregion
}