using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;
using Lerbaek.NetDaemon.Common.Converters.Json;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Might exclude members from serialization.")]
public record ControllerBleRequestBase : RequestBase
{
    public ControllerBleRequestBase(NordluxConfig config) : base(config)
    {
        HouseId = config.HouseId;
        Version = config.ApiVersions.ControllerBle;
    }

    [JsonPropertyName("addressType")]
    public int AddressType => 1;

    [JsonPropertyName("appkeyIndex")]
    public int AppKeyIndex => 0;

    [JsonPropertyName("conAddress")]
    public int ControlAddress => 49152;

    [JsonPropertyName("elemIndex")]
    public int ElemIndex => 0;

    [JsonPropertyName("houseId")]
    public string HouseId { get; init; }

    [JsonPropertyName("roomCode")]
    public int RoomCode => 1;

    [JsonPropertyName("targetId")]
    public string TargetId => "54fdcc619d9b4f37848edc6da6ea156b";

    [JsonPropertyName("targetType")]
    public int TargetType => (int)ThingType.Gateway;

    [JsonPropertyName("type")]
    public int Type => 1;

    [JsonPropertyName("uv")]
    public int Uv => 0;

    public override void OnSerializing()
    {
        ControllerBleRequestValidator.Instance.ValidateAndThrow(this);
    }

    public ControllerBleRequest Set(Control control) => new(Config, control);

    public ControllerBleRequest SetBrightness(int percentage) => Set(new Control("bri", $"{percentage}"));

    public ControllerBleRequest SetTemperature(int percentage)
    {
        var temperature = PercentageToTemperatureConverter.ToTemperature(percentage);
        return Set(new Control("cct", $"{temperature}"));
    }

    public ControllerBleRequest TurnOn() => SetPowerState(true);
    public ControllerBleRequest TurnOff() => SetPowerState(false);

    private ControllerBleRequest SetPowerState(bool on)
    {
        var state = on ? "10000" : "15000";
        return Set(new Control("cct", state));
    }
}

public record ControllerBleRequest : ControllerBleRequestBase
{
    public ControllerBleRequest(NordluxConfig config, Control control) : base(config)
    {
        ControlList = [control];
    }

    [JsonPropertyName("conList")]
    public IEnumerable<Control>? ControlList { get; }
}