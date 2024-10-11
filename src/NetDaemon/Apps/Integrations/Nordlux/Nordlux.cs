using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.ResponseModel;
using Lerbaek.NetDaemon.Common;
using Lerbaek.NetDaemon.Common.Converters;
using Lerbaek.NetDaemon.Common.Entities;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

/// <summary>
///   Application to control Nordlux lights.
/// </summary>
[Focus]
[NetDaemonApp]
public class Nordlux : ServiceHandler
{
  private readonly IHomeAssistantApiManager _apiManager;
  private readonly ILogger<Nordlux> _logger;
  private readonly IRequestHandler _requestHandler;
  private readonly NordluxConfig _config;

  public Nordlux(
    IHaContext haContext,
    IAppConfig<NordluxConfig> config,
    ILogger<Nordlux> logger,
    IHomeAssistantApiManager apiManager,
    IRequestHandler requestHandler)
    : base(haContext, "olivetreebranch")
  {
    _config = config.Value;
    _logger = logger;
    _apiManager = apiManager;
    _requestHandler = requestHandler;

    RegisterServices();
  }

  private readonly Spectrum _percentageSpectrum = new(1, 100);
  private readonly Spectrum _byteSpectrum = new(1, 255);
  private readonly Spectrum _temperatureSpectrum = new(153, 500);

  private void RegisterServices()
  {
    RegisterService<BrightnessData>(
        "setbrightness",
        data => OliveTreeBranchSetBrightness(data.Percentage));

    RegisterService<TemperatureData>(
        "setcolortemperature",
        data => OliveTreeBranchSetColorTemperature(data.Kelvin));
    
    RegisterService("turnon",    OliveTreeBranchTurnOn);
    RegisterService("turnoff",   OliveTreeBranchTurnOff);
    RegisterService("getstatus", OliveTreeBranchGetStatus);
  }

  #region Records

  public record BrightnessData(int Percentage);
  public record TemperatureData(int Kelvin);

  #endregion

  #region Services

  public async Task OliveTreeBranchTurnOff()
  {
    LogServiceCall(_logger, nameof(OliveTreeBranchTurnOff));
    await HandlerSetterService(nameof(OliveTreeBranchTurnOff), Power.Off);
  }

  public async Task OliveTreeBranchTurnOn()
  {
    LogServiceCall(_logger, nameof(OliveTreeBranchTurnOn));
    await HandlerSetterService(nameof(OliveTreeBranchTurnOn), Power.On);
  }

  public async Task OliveTreeBranchSetBrightness(int brightness)
  {
    LogServiceCall(_logger, nameof(OliveTreeBranchSetBrightness));
    var brightnessPercentage = brightness.ShiftRange(_byteSpectrum, _percentageSpectrum);
    await HandlerSetterService(nameof(OliveTreeBranchSetBrightness), new Brightness(brightnessPercentage));
  }

  /// <param name="temperature">Range: 153 (cold) - 500 (warm)</param>
  public async Task OliveTreeBranchSetColorTemperature(int temperature)
  {
    LogServiceCall(_logger, nameof(OliveTreeBranchSetColorTemperature));
    var temperaturePercentage = temperature.ShiftRange(_temperatureSpectrum, _percentageSpectrum).Reverse(_percentageSpectrum);
    await HandlerSetterService(nameof(OliveTreeBranchSetColorTemperature), new Temperature(temperaturePercentage));
  }

  public async Task OliveTreeBranchGetStatus()
  {
    LogServiceCall(_logger, nameof(OliveTreeBranchGetStatus));
    var status = await GetStatus();

    var deviceList = status.Data!.DeviceList!.ToArray();

    if (deviceList.Length == 0)
    {
      _logger.LogWarning("No devices were found when retrieving status. Assert that the ciphers are still valid.");
      return;
    }

    var entity = new LightEntities(HaContext).OliveTreeBranch;

    var onlineDevices = deviceList.Where(dl => dl.IsOnline()).ToArray();
    var isOnline = onlineDevices.Length != 0;
    var state = isOnline
      ? "on"
      : "off";
    var attributes = entity.Attributes;
    if (isOnline && attributes is not null)
    {
      var brightness = ((int)onlineDevices.Average(d => d.Bri)!).ShiftRange(_percentageSpectrum, _byteSpectrum);
      var temperature = ((int)onlineDevices.Average(d => d.Cct)! % 100).ShiftRange(_percentageSpectrum, _temperatureSpectrum)
        .Reverse(_temperatureSpectrum);
      attributes = attributes.Set(brightness, colorTemp: temperature);
    }

    await _apiManager.SetEntityStateAsync(entity.EntityId, state, attributes, CancellationToken.None);
  }

  private async Task HandlerSetterService(string serviceName, Con con)
  {
    var setStatusBody =
      $$"""
      {
          "accountId": "{{_config.AccountId}}",
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
          "houseId": "{{_config.HouseId}}",
          "roomCode": 1,
          "targetId": "54fdcc619d9b4f37848edc6da6ea156b",
          "targetType": 2,
          "token": "{{_config.Token}}",
          "type": 1,
          "uv": 0,
          "appCode": "{{_config.AppCode}}",
          "appVersion": "{{_config.AppVersion}}",
          "bulid_v": {{_config.BulidV}},
          "mobileSystemType": "{{_config.MobileSystemType}}",
          "version": "{{_config.Version}}"
      }
      """;
    LogServiceCall(_logger, serviceName);
    await _requestHandler.Send(setStatusBody);
    await OliveTreeBranchGetStatus();
  }

  private async Task<Status> GetStatus()
  {
    try
    {
      var getStatusBody =
        $$"""
          {
            "accountId":"{{_config.AccountId}}",
            "houseId":"{{_config.HouseId}}",
            "token":"{{_config.Token}}",
            "appCode":"{{_config.AppCode}}",
            "appVersion":"{{_config.AppVersion}}",
            "bulid_v":{{_config.BulidV}},
            "mobileSystemType":"{{_config.MobileSystemType}}",
            "uniqueIndication":"{{_config.UniqueIndication}}",
            "version":"{{_config.Version}}"
          }
          """;

      var response = await _requestHandler.Send(
        getStatusBody,
        ApiPathConstants.GetBulbStatus);
      
      var content = await response.Content.ReadAsStringAsync();
      _logger.LogTrace("Status:{NewLine}{Content}", NewLine, content);
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