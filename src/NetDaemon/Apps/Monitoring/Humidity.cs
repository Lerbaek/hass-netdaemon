using Lerbaek.NetDaemon.Common.Reflection;

namespace Lerbaek.NetDaemon.Apps.Monitoring;

[NetDaemonApp]
//[Focus]
public class Humidity
{
  private readonly ILogger<Humidity> _logger;
  private readonly INotificationBuilder _notificationBuilder;
  private readonly (int Low, int High) _limits = (40, 60);
  private readonly NotifyServices _notifyServices;
  private readonly DeviceTrackerEntities _deviceTrackers;
  private Dictionary<string, List<BinarySensorEntity>> _windowDoorSensorsByArea = null!;
  private ClimateEntity[] _climateEntities = null!;

  private bool IsHome => _deviceTrackers.KristoffersGalaxyS20Ultra.State is "home";

  public Humidity(IHaContext ha, ILogger<Humidity> logger, INotificationBuilder notificationBuilder)
  {
    _logger = logger;
    _notificationBuilder = notificationBuilder;
    _notifyServices = new NotifyServices(ha);
    _deviceTrackers = new DeviceTrackerEntities(ha);
    ResolveWindowSensors(ha);
    SubscribeToClimateEntities(ha);
  }

  private void ResolveWindowSensors(IHaContext ha)
  {
    var sensors = new BinarySensorEntities(ha);
    _windowDoorSensorsByArea = sensors
      .GetPropertiesOfType<BinarySensorEntity>()
      .Where(s => s.Attributes is { DeviceClass: "window", Contact: { } })
      .GroupBy(s =>
      {
        if (s.Area is not null)
          return s.Area;

        const string errorMsg = "{0} is not assigned to any area.";
        var e = new NullReferenceException(string.Format(errorMsg, s.EntityId));
        _logger.LogError(e, "{EntityId} is not assigned to any area.", s.EntityId);
        throw e;
      })
      .ToDictionary(g => g.Key, g => g.ToList());
  }

  private void SubscribeToClimateEntities(IHaContext ha)
  {
    var entities = new ClimateEntities(ha);
    _climateEntities = entities.GetPropertiesOfType<ClimateEntity>().ToArray();
    foreach (var climateEntity in _climateEntities)
    {
      climateEntity.StateAllChanges().Where(HumidityOutOfRange).Subscribe(CheckHumidity);
      if (climateEntity.Attributes != null)
        _logger.LogInformation("Overvåger luftfugtighed i {Room}", climateEntity.Attributes.FriendlyName);
    }
  }

  private void CheckHumidity(StateChange change)
  {
    var climate = (ClimateEntity)change.Entity;
    var humidity = climate.Attributes!.CurrentHumidity;
    var low = humidity < _limits.Low;
    var title = (low ? "Lav" : "Høj") + " luftfugtighed!";
    var friendlyName = climate.Attributes.FriendlyName;

    _logger.LogDebug("{FriendlyName}: {Humidity}%.", friendlyName, humidity);
    
    if(_windowDoorSensorsByArea.TryGetValue(climate.Area!, out var sensors) && sensors.Any(s => s.IsOn()))
    {
      _logger.LogDebug("{FriendlyName}: Der udluftes allerede.", friendlyName);
      return;
    }

    if (!IsHome)
    {
      _logger.LogDebug("{FriendlyName}: Kristoffer er ikke hjemme, så ingen notifikation sendt.", friendlyName);
      return;
    }

    // Set color too

    var notificationMessage = string.Join(
      NewLine,
      _climateEntities.Where(
          ce => ce.Attributes?.CurrentHumidity is {} currentHumidity &&
                (currentHumidity < _limits.Low || currentHumidity > _limits.High))
        .Select(
          sba =>
            $"{sba.Attributes!.FriendlyName}: {sba.Attributes!.CurrentHumidity}%."));
    _notificationBuilder
      .SetTitle(title)
      .SetMessage(notificationMessage)
      .SetChannel("Humidity alert")
      .SetTag(nameof(Humidity))
      .Notify(_notifyServices.KristoffersTelefon);
  }

  private bool HumidityOutOfRange(StateChange change)
  {
    if (change.Entity is not ClimateEntity climate)
      return false;

    var humidity = climate.Attributes?.CurrentHumidity;

    if (humidity is null)
    {
      _logger.LogWarning("Ingen værdi for luftfugtighed fundet i {EntityId}.", climate.EntityId);
      return false;
    }

    return humidity < _limits.Low || humidity > _limits.High;
  }
}