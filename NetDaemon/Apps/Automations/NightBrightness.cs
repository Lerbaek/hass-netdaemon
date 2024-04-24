using Lerbaek.NetDaemon.Common.Converters;
using Lerbaek.NetDaemon.Common.Logging;

namespace Lerbaek.NetDaemon.Apps.Automations;

[NetDaemonApp]
//[Focus]
public class NightBrightness
{
  private const int NightBrightnessPercentage = 1;
  private const int MaxBrightnessPercentage = 100;
  private readonly IHaContext ha;
  private readonly ILogger<NightBrightness> logger;

  private IEnumerable<LightEntity> ExcludedLights => new[]
  {
    lights.Alang,
    lights.AlleIndendorsLys,
    lights.BadevaerelseGu53,
    lights.Ballon,
    lights.FelenaTassel,
    lights.FelenaTassel,
    lights.GarageLanterne,
    lights.Indkorsel,
    lights.LysForanGaragen,
    lights.LysIBaghaven,
    lights.LysIBryggerset,
    lights.LysIEntreen,
    lights.LysIFordelingsgangen,
    lights.LysIKokkenet,
    lights.LysIStuen,
    lights.LysPaBadevaerelset,
    lights.LysPaEbbesVaerelse,
    lights.LysPaRoarsVaerelse,
    lights.LysPaSovevaerelset,
    lights.LysPaToilettet,
    lights.Maane,
    lights.PartialIndkorsel1,
    lights.PartialIndkorsel2,
    lights.PartialIndkorsel3,
    lights.PartialIndkorsel4,
    lights.PartialIndkorsel5,
    lights.Toilet,
  };

  private readonly InputBooleanEntities inputBooleans;
  private readonly LightEntities lights;

  public NightBrightness(IHaContext ha, ILogger<NightBrightness> logger)
  {
    this.ha = ha;
    this.logger = logger;
    inputBooleans = new InputBooleanEntities(ha);
    lights = new LightEntities(ha);
    ha.StateChanges().Subscribe(SetBrightness);
    inputBooleans.NightMode.StateChanges().Subscribe(ResetBrightness);
  }

  private void ResetBrightness(StateChange change)
  {
    try
    {
      if (change.New.IsOn())
        return;

      var allLights = typeof(LightEntities).GetProperties().Select(p => p.GetMethod!.Invoke(lights, null) as LightEntity);
      foreach (var light in allLights.Where(light =>
                 light is not null
                 && !IsExcluded(light.EntityId)
                 && light.Attributes!.Brightness is < 255))
        light!.TurnOff();
    }
    catch (Exception e)
    {
      logger.LogErrorMethod(e);
    }
  }

  private void SetBrightness(StateChange change)
  {
    try
    {
      if (!SpecificBrightnessRequired(change))
        return;

      var brightnessPercentage = inputBooleans.NightMode.IsOn()
        ? NightBrightnessPercentage
        : MaxBrightnessPercentage;

      var entityId = change.Entity.EntityId;
      var light = new LightEntity(ha, entityId);
      var name = light.Attributes?.FriendlyName ?? entityId;

      if (light.Attributes!.Brightness is null)
      {
        logger.LogTrace("{name} has no brightness attribute", name);
        return;
      }

      var currentBrightnessPercentage = ((int)light.Attributes!.Brightness!.Value).ShiftRange((0, 255), (0, MaxBrightnessPercentage));

      if (Math.Abs(currentBrightnessPercentage - brightnessPercentage) < 0.1)
      {
        logger.LogTrace("{name} is already at {brightnessPercentage}%", name, brightnessPercentage);
        return;
      }

      logger.LogDebug("Setting brightness of {name} from {from} to {to}", name, currentBrightnessPercentage, brightnessPercentage);
    
      light.TurnOn(brightnessPct: brightnessPercentage);
    }
    catch (Exception e)
    {
      logger.LogErrorMethod(e);
    }
  }

  private bool SpecificBrightnessRequired(StateChange change)
  {
    var entityId = change.Entity.EntityId;

    if (!entityId.StartsWith("light."))
    {
      logger.LogTrace("{name} is not a light entity", entityId);
      return false;
    }

    var light = new LightEntity(ha, entityId);
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
      logger.LogTrace("{name} is excluded", name);
      return false;
    }

    if (change.Old.IsOn())
    {
      logger.LogTrace("{name} is already on", name);
      return false;
    }

    if (change.New.IsOff())
    {
      logger.LogTrace("{name} has been turned off", name);
      return false;
    }

    return true;
  }

  private bool IsExcluded(string entityId) => ExcludedLights.Any(light => light.EntityId == entityId);
}