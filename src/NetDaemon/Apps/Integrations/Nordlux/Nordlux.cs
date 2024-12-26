using System.Diagnostics.CodeAnalysis;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model.ActionData;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.ResponseModel;
using Lerbaek.NetDaemon.Common;
using Lerbaek.NetDaemon.Common.Converters;
using Lerbaek.NetDaemon.Common.Logging;
using static Lerbaek.NetDaemon.Common.Converters.SpectrumConverter;
using Device = Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model.Device;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux;

/// <summary>
/// Provides methods to register and handle the Nordlux bulbs in the <i>Olive Tree Branch</i> lamp.
/// </summary>
//[Focus]
[NetDaemonApp]
public class Nordlux : ServiceHandler
{
    private readonly ILogger<Nordlux> _logger;
    private readonly IHomeAssistantApiManager _apiManager;
    private readonly IRequestHandler _requestHandler;
    private readonly NordluxConfig _config;
    private readonly LightEntities _lightEntities;

    /// <summary>
    /// Base payload for controller requests.
    /// </summary>
    private readonly ControllerBleRequestBase _controllerBleRequest;

    /// <summary>
    /// Payload for status requests.
    /// </summary>
    private readonly GetDeviceStatusRequest _getStatusBody;

    /// <summary>
    /// Latest known status of each device.
    /// </summary>
    private Device[] _deviceList = [];

    /// <inheritdoc cref="Nordlux"/>
    /// <param name="haContext">The Home Assistant context.</param>
    /// <param name="logger">Logger for the Nordlux class.</param>
    /// <param name="apiManager">API manager for Home Assistant interactions.</param>
    /// <param name="requestHandler">Handler for HTTP requests.</param>
    /// <param name="config">Configuration for the Nordlux integration.</param>
    /// <param name="lightEntities">Access point for entities representing lights in Home Assistant.</param>
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

    /// <summary>
    /// Turns off the Olive Tree Branch device.
    /// </summary>
    /// 
    /// <example>
    /// To call this method from Home Assistant, use the following service call:
    ///   <code>
    ///     action: netdaemon.olivetreebranch_turnoff
    ///   </code>
    /// </example>
    public async Task OliveTreeBranchTurnOff()
    {
        using var logScope = _logger.BeginScopeWithCorrelationId();
        LogServiceCall(_logger);
        await SetStatus(_controllerBleRequest.TurnOff());
    }

    /// <summary>
    /// Turns on the Olive Tree Branch device.
    /// </summary>
    /// 
    /// <example>
    /// To call this method from Home Assistant, use the following service call:
    ///   <code>
    ///     action: netdaemon.olivetreebranch_turnon
    ///   </code>
    /// </example>
    public async Task OliveTreeBranchTurnOn()
    {
        using var logScope = _logger.BeginScopeWithCorrelationId();
        LogServiceCall(_logger);
        await SetStatus(_controllerBleRequest.TurnOn());
    }

    /// <summary>
    /// Sets the brightness of the Olive Tree Branch device.
    /// </summary>
    /// 
    /// <param name="data">The brightness data containing the desired brightness level.</param>
    /// 
    /// <example>
    /// To call this method from Home Assistant, use the following service call:
    ///   <code>
    ///     action: netdaemon.olivetreebranch_setbrightness
    ///     data:
    ///       Brightness: "{{ brightness }}"
    ///   </code>
    /// </example>
    public async Task OliveTreeBranchSetBrightness(BrightnessData data)
    {
        using var logScope = _logger.BeginScopeWithCorrelationId((nameof(data), data));
        LogServiceCall(_logger);
        var percentage = data.Brightness.ShiftRange(ByteSpectrum, PercentageSpectrum);
        await SetStatus(_controllerBleRequest.SetBrightness(percentage));
    }

    /// <summary>
    /// Sets the color temperature of the Olive Tree Branch device.
    /// </summary>
    /// 
    /// <param name="data">The temperature data containing the desired color temperature.</param>
    /// 
    /// <remarks>
    /// This method is called when the "olivetreebranch_setcolortemperature" service is invoked from Home Assistant.
    /// </remarks>
    /// 
    /// <example>
    /// To call this method from Home Assistant, use the following service call:
    ///   <code>
    ///     action: netdaemon.olivetreebranch_setcolortemperature
    ///     data:
    ///       Temperature: "{{ color_temp }}"
    ///   </code>
    /// </example>
    public async Task OliveTreeBranchSetColorTemperature(TemperatureData data)
    {
        using var logScope = _logger.BeginScopeWithCorrelationId((nameof(data), data));
        LogServiceCall(_logger);
        var percentage = data.Value.ShiftRange(TemperatureSpectrum, PercentageSpectrum).Reverse(PercentageSpectrum);
        await SetStatus(_controllerBleRequest.SetTemperature(percentage));
    }

    /// <summary>
    /// Retrieves the current status of the device and updates the status of the Olive Tree Branch light.
    /// </summary>
    /// 
    /// <example>
    /// To call this method from Home Assistant, use the following service call:
    ///   <code>
    ///     action: netdaemon.olivetreebranch_getstatus
    ///   </code>
    /// </example>
    public async Task OliveTreeBranchUpdateStatus()
    {
        using var logScope = _logger.BeginScopeWithCorrelationId();
        LogServiceCall(_logger);
        await GetStatus();

        if (_deviceList is { Length: 0 })
        {
            _logger.LogWarning("No devices were found when retrieving status.");
            return;
        }

        var entity = _lightEntities.OliveTreeBranch;

        //var onlineDevices = _deviceList.Where(dl => dl.IsOnline).ToArray();
        var onlineDevices = _deviceList.Where(dl => dl.Power).ToArray(); // Temporary line
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

    /// <summary>
    /// Sets the status of the Olive Tree Branch device and updates its current state.
    /// </summary>
    /// 
    /// <param name="setStatusBody">The request body containing the new status to be set. Can be created from a <see cref="ControllerBleRequestBase"/>.</param>
    /// 
    /// <remarks>
    /// This method sends a request to update the device status and then retrieves
    /// the updated status to ensure the internal state is synchronized.
    /// </remarks>
    private async Task SetStatus(ControllerBleRequest setStatusBody)
    {
        LogServiceCall(_logger);
        await _requestHandler.Send(setStatusBody);
        await OliveTreeBranchUpdateStatus();
    }

    /// <summary>
    /// Reports the status of the devices after applying a configuration function.
    /// </summary>
    /// 
    /// <param name="configureDevices">A function that configures each device setter.</param>
    /// 
    /// <remarks>
    /// Reporting the status does not affect the lights, but it does update the internal provider
    /// state, and will be returned when getting status again.
    /// <br/>
    /// The purpose of this method is to ensure that the server state reflects reality when
    /// locally changing the state, for example through Bluetooth or local gateway communication.
    /// </remarks>
    [SuppressMessage("ReSharper", "UnusedMember.Local")]
    [SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Might come in handy")]
    private async Task ReportStatus(Func<DeviceSetter, DeviceSetter> configureDevices)
    {
        LogServiceCall(_logger);
        if (_deviceList is { Length: 0 })
            await GetStatus();

        var setStatusBody = new ReportBulbStatusRequest(_config, _deviceList.Select(configureDevices));

        await _requestHandler.Send(setStatusBody, ApiServiceConstants.ReportBulbStatus);
        await OliveTreeBranchUpdateStatus();
    }

    /// <summary>
    /// Retrieves the current status of all devices.
    /// </summary>
    /// 
    /// <remarks>
    /// This method sends a request to get the device status, deserializes the response,
    /// and populates the internal device list with non-gateway devices.
    /// </remarks>
    /// 
    /// <exception cref="NordluxException">Thrown when the status deserialization fails.</exception>
    private async Task GetStatus()
    {
        var response = await _requestHandler.Send(
            _getStatusBody,
            ApiServiceConstants.GetDeviceStatus);

        var content = await response.Content.ReadAsStringAsync();
        _logger.LogTrace("Status: {Status}", content);

        var status = JsonSerializer.Deserialize<Status>(content)
                     ?? throw new NordluxException("Failed to get status");

        _deviceList = status.Data.DeviceList.Where(device => device.ThingType != ThingType.Gateway).ToArray();
    }
}