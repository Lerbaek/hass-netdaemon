using System.Text.Json;
using Lerbaek.NetDaemon.Common.Converters;
using Lerbaek.NetDaemon.Common.Logging;
using static Lerbaek.NetDaemon.Common.Converters.SpectrumConverter;

namespace Lerbaek.NetDaemon.Apps.Automations;

[NetDaemonApp]
//[Focus]
public class NightBrightness
{
  private const int NightBrightnessPercentage = 1;
  private const int MaxBrightnessPercentage = 100;
  private readonly IHaContext _ha;
  private readonly ILogger<NightBrightness> _logger;

  private IEnumerable<LightEntity> ExcludedLights =>
  [
    _lights.Alang,
    _lights.AlleIndendorsLys,
    _lights.BadevaerelseGu53,
    _lights.Ballon,
    _lights.FelenaTassel,
    _lights.FelenaTassel,
    _lights.GarageLanterne,
    _lights.Indkorsel,
    _lights.LysForanGaragen,
    _lights.LysIBaghaven,
    _lights.LysIBryggerset,
    _lights.LysIEntreen,
    _lights.LysIFordelingsgangen,
    _lights.LysIKokkenet,
    _lights.LysIStuen,
    _lights.LysPaBadevaerelset,
    _lights.LysPaEbbesVaerelse,
    _lights.LysPaRoarsVaerelse,
    _lights.LysPaSovevaerelset,
    _lights.LysPaToilettet,
    _lights.Maane,
    _lights.PartialIndkorsel1,
    _lights.PartialIndkorsel2,
    _lights.PartialIndkorsel3,
    _lights.PartialIndkorsel4,
    _lights.PartialIndkorsel5,
    _lights.Toilet,
  ];

  private readonly InputBooleanEntities _inputBooleans;
  private readonly LightEntities _lights;

  public NightBrightness(IHaContext ha, ILogger<NightBrightness> logger)
  {
    _ha = ha;
    _logger = logger;
    _inputBooleans = new InputBooleanEntities(ha);
    _lights = new LightEntities(ha);
    ha.StateChanges().Where(SpecificBrightnessRequired).Subscribe(SetBrightness);
    _inputBooleans.NightMode.StateChanges().Subscribe(ResetBrightness);
  }

  private void ResetBrightness(StateChange change)
  {
    try
    {
      if (change.New.IsOn())
        return;

      var allLights = typeof(LightEntities).GetProperties().Select(p => p.GetMethod!.Invoke(_lights, null) as LightEntity);
      foreach (var light in allLights.Where(light =>
                 light is not null
                 && !IsExcluded(light.EntityId)
                 && light.Attributes!.Brightness is < 255))
        light!.TurnOff();
    }
    catch (Exception e)
    {
      _logger.LogErrorMethod(e);
    }
  }

  private void SetBrightness(StateChange change)
  {
    try
    {
      var brightnessPercentage = _inputBooleans.NightMode.IsOn()
        ? NightBrightnessPercentage
        : MaxBrightnessPercentage;

      var entityId = change.Entity.EntityId;
      var light = new LightEntity(_ha, entityId);
      var name = light.Attributes?.FriendlyName ?? entityId;

      if (light.Attributes!.Brightness is null)
      {
        _logger.LogTrace("{Name} has no brightness attribute", name);
        return;
      }

      var currentBrightnessPercentage = ((JsonElement)light.Attributes!.Brightness).GetInt32().ShiftRange(ByteSpectrum, PercentageSpectrum);

      if (currentBrightnessPercentage == brightnessPercentage)
      {
        _logger.LogTrace("{Name} is already at {BrightnessPercentage}%", name, brightnessPercentage);
        return;
      }

      _logger.LogDebug("Setting brightness of {Name} from {From} to {To}", name, currentBrightnessPercentage, brightnessPercentage);
    
      light.TurnOn(brightnessPct: brightnessPercentage);
    }
    catch (Exception e)
    {
      _logger.LogErrorMethod(e);
    }
  }

  private bool SpecificBrightnessRequired(StateChange change)
  {
    var entityId = change.Entity.EntityId;

    if (!entityId.StartsWith("light."))
    {
      _logger.LogTrace("{Name} is not a light entity", entityId);
      return false;
    }

    var light = new LightEntity(_ha, entityId);
    string? name;
    try
    {
      name = light.Attributes?.FriendlyName ?? entityId;
    }
    catch
    {
      return false;
    }

    if (IsExcluded(entityId))
    {
      _logger.LogTrace("{Name} is excluded", name);
      return false;
    }

    if (change.Old.IsOn())
    {
      _logger.LogTrace("{Name} is already on", name);
      return false;
    }

    if (change.New.IsOff())
    {
      _logger.LogTrace("{Name} has been turned off", name);
      return false;
    }

    return true;
  }

  private bool IsExcluded(string entityId) => ExcludedLights.Any(light => light.EntityId == entityId);
}