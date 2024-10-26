using System.Runtime.CompilerServices;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model.ActionData;
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
    private readonly ILogger<Nordlux> _logger;
    private readonly IHomeAssistantApiManager _apiManager;
    private readonly IRequestHandler _requestHandler;
    private readonly NordluxConfig _config;
    private readonly LightEntities _lightEntities;

    private readonly ControllerBleRequestBase _controllerBleRequest;
    private readonly GetDeviceStatusRequest _getStatusBody;

    private Device[] _deviceList = [];

    public Nordlux(IHaContext haContext,
        ILogger<Nordlux> logger,
        IHomeAssistantApiManager apiManager,
        IRequestHandler requestHandler,
        IAppConfig<NordluxConfig> config,
        LightEntities lightEntities)
    : base(haContext, "olivetreebranch")
    {
        _config = config.Value;
        _logger = logger;
        _apiManager = apiManager;
        _requestHandler = requestHandler;
        _lightEntities = lightEntities;

        _controllerBleRequest = new ControllerBleRequestBase(_config);
        _getStatusBody = new GetDeviceStatusRequest(_config);

        RegisterService<BrightnessData>("setbrightness", OliveTreeBranchSetBrightness);
        RegisterService<TemperatureData>("setcolortemperature", OliveTreeBranchSetColorTemperature);

        RegisterService("turnon", OliveTreeBranchTurnOn);
        RegisterService("turnoff", OliveTreeBranchTurnOff);
        RegisterService("getstatus", OliveTreeBranchUpdateStatus);
    }

    public async Task OliveTreeBranchTurnOff()
    {
        LogServiceCall(_logger);
        await SetStatus(_controllerBleRequest.TurnOff());
    }

    public async Task OliveTreeBranchTurnOn()
    {
        LogServiceCall(_logger);
        await SetStatus(_controllerBleRequest.TurnOn());
    }

    public async Task OliveTreeBranchSetBrightness(BrightnessData data)
    {
        LogServiceCall(_logger);
        var percentage = data.Brightness.ShiftRange(ByteSpectrum, PercentageSpectrum);
        await SetStatus(_controllerBleRequest.SetBrightness(percentage));
    }

    public async Task OliveTreeBranchSetColorTemperature(TemperatureData data)
    {
        LogServiceCall(_logger);
        var percentage = data.Value.ShiftRange(TemperatureSpectrum, PercentageSpectrum).Reverse(PercentageSpectrum);
        await SetStatus(_controllerBleRequest.SetTemperature(percentage));
    }

    public async Task OliveTreeBranchUpdateStatus()
    {
        LogServiceCall(_logger);
        await GetStatus();

        if (_deviceList is { Length: 0 })
        {
            _logger.LogWarning("No devices were found when retrieving status.");
            return;
        }

        var entity = _lightEntities.OliveTreeBranch;

        var onlineDevices = _deviceList.Where(dl => dl.IsOnline).ToArray();
        var anyOn = onlineDevices.Any(device => device.Power);
        //var anyOnline = onlineDevices is { Length: > 0 }; // Temporarily disabled due to provider faultily reporting devices offline

        var state = //anyOnline ?
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

    private async Task SetStatus(ControllerBleRequest setStatusBody, [CallerMemberName] string serviceName = "")
    {
        LogServiceCall(_logger, serviceName);
        await _requestHandler.Send(setStatusBody);
        await OliveTreeBranchUpdateStatus();
    }

    private async Task ReportStatus(Func<DeviceSetter, DeviceSetter> configureDevices, [CallerMemberName] string serviceName = "")
    {
        LogServiceCall(_logger, serviceName);
        if (_deviceList is { Length: 0 })
            await GetStatus();

        var setStatusBody = new ReportBulbStatusRequest(_config, _deviceList.Select(configureDevices));

        await _requestHandler.Send(setStatusBody, ApiPathConstants.ReportBulbStatus);
        await OliveTreeBranchUpdateStatus();
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
}