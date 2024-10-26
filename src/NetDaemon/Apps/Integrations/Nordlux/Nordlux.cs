using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.ResponseModel;
using Lerbaek.NetDaemon.Common;
using Lerbaek.NetDaemon.Common.Converters;
using static Lerbaek.NetDaemon.Common.Converters.SpectrumConverter;
using Device = Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model.Device;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

/// <summary>
/// Application to control Nordlux lights.
/// </summary>
[Focus]
[NetDaemonApp]
public class Nordlux : ServiceHandler
{
    private readonly IHomeAssistantApiManager _apiManager;
    private readonly ILogger<Nordlux> _logger;
    private readonly IRequestHandler _requestHandler;
    private readonly NordluxConfig _config;

    private readonly GetDeviceStatusRequest _getStatusBody;
    private readonly ControllerBleRequestBase _controllerBleRequestBase;

    private Device[] _deviceList = [];

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

        _getStatusBody = new GetDeviceStatusRequest(_config);
        _controllerBleRequestBase = new ControllerBleRequestBase(_config);

        RegisterServices();
    }

    private void RegisterServices()
    {
        RegisterService<BrightnessData>(
            "setbrightness",
            data => OliveTreeBranchSetBrightness(data.Brightness));

        RegisterService<TemperatureData>(
            "setcolortemperature",
            data => OliveTreeBranchSetColorTemperature(data.Value));

        RegisterService("turnon", OliveTreeBranchTurnOn);
        RegisterService("turnoff", OliveTreeBranchTurnOff);
        RegisterService("getstatus", OliveTreeBranchGetStatus);
    }

    #region Records

    public record BrightnessData(int Brightness);

    public record TemperatureData(int Value);

    #endregion

    #region Actions

    public async Task OliveTreeBranchTurnOff()
    {
        LogServiceCall(_logger, nameof(OliveTreeBranchTurnOff));
        await SetStatus(nameof(OliveTreeBranchTurnOff), _controllerBleRequestBase.TurnOff());
    }

    public async Task OliveTreeBranchTurnOn()
    {
        LogServiceCall(_logger, nameof(OliveTreeBranchTurnOn));
        await SetStatus(nameof(OliveTreeBranchTurnOn), _controllerBleRequestBase.TurnOn());
    }

    public async Task OliveTreeBranchSetBrightness(int brightness)
    {
        LogServiceCall(_logger, nameof(OliveTreeBranchSetBrightness));
        var percentage = brightness.ShiftRange(ByteSpectrum, PercentageSpectrum);
        await SetStatus(nameof(OliveTreeBranchSetBrightness), _controllerBleRequestBase.SetBrightness(percentage));
    }

    /// <param name="temperature">Range: 153 (cold) - 500 (warm)</param>
    public async Task OliveTreeBranchSetColorTemperature(int temperature)
    {
        LogServiceCall(_logger, nameof(OliveTreeBranchSetColorTemperature));
        var percentage = temperature.ShiftRange(TemperatureSpectrum, PercentageSpectrum).Reverse(PercentageSpectrum);
        await SetStatus(nameof(OliveTreeBranchSetBrightness), _controllerBleRequestBase.SetTemperature(percentage));
    }

    public async Task OliveTreeBranchGetStatus()
    {
        LogServiceCall(_logger, nameof(OliveTreeBranchGetStatus));
        await GetStatus();

        if (_deviceList is { Length: 0 })
        {
            _logger.LogWarning("No devices were found when retrieving status.");
            return;
        }

        var entity = new LightEntities(HaContext).OliveTreeBranch;

        var onlineDevices = _deviceList.Where(dl => dl.IsOnline).ToArray();
        var anyOn = onlineDevices.Any(device => device.Power);
        var anyOnline = onlineDevices is { Length: > 0 };

        var state = //anyOnline ? Temporarily disabled due to provider faultily reporting devices offline
            anyOn
                ? "on"
                : "off";
            //: "unavailable";

        var attributes = entity.Attributes;
        if (anyOn && attributes is not null)
        {
            var brightness = ((int)onlineDevices.Average(d => d.Brightness))
                .ShiftRange(PercentageSpectrum, ByteSpectrum);

            var temperature = ((int)onlineDevices.Average(d => d.Temperature))
                .ShiftRange(PercentageSpectrum, TemperatureSpectrum)
                .Reverse(TemperatureSpectrum);

            attributes = attributes with
            {
                Brightness = brightness,
                ColorTemp = temperature
            };
        }

        await _apiManager.SetEntityStateAsync(entity.EntityId, state, attributes, CancellationToken.None);
    }

    private async Task SetStatus(string serviceName, ControllerBleRequest setStatusBody)
    {
        LogServiceCall(_logger, serviceName);
        await _requestHandler.Send(setStatusBody);
        await OliveTreeBranchGetStatus();
    }

    /// <summary>
    /// Set
    /// </summary>
    /// <param name="serviceName"></param>
    /// <param name="configureDevices"></param>
    /// <returns></returns>
    private async Task ReportStatus(string serviceName, Func<DeviceSetter, DeviceSetter> configureDevices)
    {
        if (_deviceList is { Length: 0 })
            await GetStatus();

        var setStatusBody = new ReportBulbStatusRequest(_config, _deviceList.Select(configureDevices));

        LogServiceCall(_logger, serviceName);
        await _requestHandler.Send(setStatusBody, ApiPathConstants.ReportBulbStatus);
        await OliveTreeBranchGetStatus();
    }

    private async Task GetStatus()
    {
        var response = await _requestHandler.Send(
            _getStatusBody,
            ApiPathConstants.GetDeviceStatus);

        var content = await response.Content.ReadAsStringAsync();
        _logger.LogTrace("Status: {Status}", content);

        var status = JsonSerializer.Deserialize<Status>(content)
                     ?? throw new NordluxException("Failed to get status");

        _deviceList = status.Data.DeviceList.Where(device => device.ThingType != ThingType.Gateway).ToArray();
    }
    #endregion
}