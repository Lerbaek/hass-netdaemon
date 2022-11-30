using Lerbaek.NetDaemon.Common.Reflection;

namespace Lerbaek.NetDaemon.Apps.Monitoring;

[NetDaemonApp]
//[Focus]
public class Humidity
{
  private readonly ILogger<Humidity> logger;
  private readonly INotificationBuilder notificationBuilder;
  private readonly (int Low, int High) limits = (40, 60);
  private readonly NotifyServices notifyServices;
  private readonly DeviceTrackerEntities deviceTrackers;
  private Dictionary<string, List<BinarySensorEntity>> windowDoorSensorsByArea = null!;
  private ClimateEntity[] climateEntities = null!;

  private bool IsHome => deviceTrackers.KristoffersGalaxyS20Ultra.State is "home";

  public Humidity(IHaContext ha, ILogger<Humidity> logger, INotificationBuilder notificationBuilder)
  {
    this.logger = logger;
    this.notificationBuilder = notificationBuilder;
    notifyServices = new NotifyServices(ha);
    deviceTrackers = new DeviceTrackerEntities(ha);
    ResolveWindowSensors(ha);
    SubscribeToClimateEntities(ha);
  }

  private void ResolveWindowSensors(IHaContext ha)
  {
    var sensors = new BinarySensorEntities(ha);
    windowDoorSensorsByArea = sensors
      .GetPropertiesOfType<BinarySensorEntity>()
      .Where(s => s.Attributes is { DeviceClass: "window", Contact: { } })
      .GroupBy(s =>
      {
        if (s.Area is not null)
          return s.Area;

        const string errorMsg = "{0} is not assigned to any area.";
        var e = new NullReferenceException(string.Format(errorMsg, s.EntityId));
        logger.LogError(e, string.Format(errorMsg, "{EntityId}"), s.EntityId);
        throw e;
      })
      .ToDictionary(g => g.Key, g => g.ToList());
  }

  private void SubscribeToClimateEntities(IHaContext ha)
  {
    var entities = new ClimateEntities(ha);
    climateEntities = entities.GetPropertiesOfType<ClimateEntity>().ToArray();
    foreach (var climateEntity in climateEntities)
    {
      climateEntity.StateAllChanges().Where(HumidityOutOfRange).Subscribe(CheckHumidity);
      if (climateEntity.Attributes != null)
        logger.LogInformation("Overvåger luftfugtighed i {Room}", climateEntity.Attributes.FriendlyName);
    }
  }

  private void CheckHumidity(StateChange change)
  {
    var climate = (ClimateEntity)change.Entity;
    var humidity = climate.Attributes!.CurrentHumidity;
    var low = humidity < limits.Low;
    var title = (low ? "Lav" : "Høj") + " luftfugtighed!";
    var friendlyName = climate.Attributes.FriendlyName;
    const string message = "{0}: {1}%.";

    logger.LogDebug(string.Format(message, "{FriendlyName}", "{Humidity}"), friendlyName, humidity);
    
    if(windowDoorSensorsByArea.TryGetValue(climate.Area!, out var sensors) && sensors.Any(s => s.IsOn()))
    {
      logger.LogDebug("{FriendlyName}: Der udluftes allerede.", friendlyName);
      return;
    }

    if (!IsHome)
    {
      logger.LogDebug("{FriendlyName}: Kristoffer er ikke hjemme, så ingen notifikation sendt.", friendlyName);
      return;
    }

    // Set color too

    var notificationMessage = string.Join(
      NewLine,
      climateEntities.Where(
          ce => ce.Attributes?.CurrentHumidity is {} currentHumidity &&
                (currentHumidity < limits.Low || currentHumidity > limits.High))
        .Select(
          sba =>
            string.Format(
              message,
              sba.Attributes!.FriendlyName,
              sba.Attributes!.CurrentHumidity)));
    notificationBuilder
      .SetTitle(title)
      .SetMessage(notificationMessage)
      .SetChannel("Humidity alert")
      .SetTag(nameof(Humidity))
      .Notify(notifyServices.MobileAppKristoffersGalaxyS20Ultra);
  }

  private bool HumidityOutOfRange(StateChange change)
  {
    if (change.Entity is not ClimateEntity climate)
      return false;

    var humidity = climate.Attributes?.CurrentHumidity;

    if (humidity is null)
    {
      logger.LogWarning("Ingen værdi for luftfugtighed fundet i {entityId}.", climate.EntityId);
      return false;
    }

    return humidity < limits.Low || humidity > limits.High;
  }
}