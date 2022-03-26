namespace Lerbaek.NetDaemon.Apps.Alarms.CarNotChargingAlarm;

/// <summary>
///   Application to perform repetitive voice alarms.
/// </summary>
[Focus]
[NetDaemonApp]
public class CarNotChargingAlarmApp
{
  private readonly IHaContext haContext;
  private readonly ILogger<CarNotChargingAlarmApp> logger;
  private readonly INotificationBuilder notificationBuilder;
  private readonly Entities entities;

  private bool EngineRunning => entities.BinarySensor.CeedEngine.IsOn();
  private bool Charging => entities.BinarySensor.CeedCharging.IsOn();
  private bool BatteryIs(int percentage) => (int)Math.Round(entities.Sensor.CeedEvBattery.State!.Value) == percentage;
  private bool CarHome => entities.DeviceTracker.CeedLocation.State is "home";
  private bool ShouldBeCharging => !Charging && !EngineRunning && !BatteryIs(0) && !BatteryIs(100) && CarHome;

  private static Color Color(int percentage)
  {
    var multiplier = 1.0 / Math.Max(percentage, 100 - percentage) * 255;
    return FromArgb((int)Math.Round((100 - percentage) * multiplier), (int)Math.Round(percentage * multiplier), 0);
  }

  public CarNotChargingAlarmApp(IHaContext haContext, ILogger<CarNotChargingAlarmApp> logger, INotificationBuilder notificationBuilder)
  {
    this.haContext = haContext;
    this.logger = logger;
    this.notificationBuilder = notificationBuilder;
    entities = new Entities(haContext);
    Task.Run(() => CarNotChargingAlarm());
    entities.Sensor.CeedLastUpdate.StateAllChanges().Subscribe(CarNotChargingAlarm);

    logger.LogInformation("Car Not Charging alarm has been initialized.");
  }

  private void CarNotChargingAlarm(dynamic? change = null)
  {
    logger.LogInformation("Evaluating charging status.");

    _ = Policy.HandleResult<NumericSensorEntity>(entity => !entity.State.HasValue)
      .WaitAndRetry(Backoff.ExponentialBackoff(FromSeconds(1), 5),
        (_, _, retryCount, _) =>
        {
          logger.LogDebug("Entities not yet available.");
          logger.LogDebug("Retry count: {RetryCount}.", retryCount);
        }).ExecuteAndCapture(() => entities.Sensor.CeedEvBattery);

    if (!entities.Sensor.CeedEvBattery.State.HasValue)
    {
      logger.LogWarning("Charging status could not be determined, entities are unavailable.");
      return;
    }

    var batteryPercentage = (int)Math.Round(entities.Sensor.CeedEvBattery.State!.Value);

    logger.LogDebug(@"
Charging: {Charging}
Engine running: {EngineRunning}
Battery: {BatteryPercentage}%
Car is home: {CarHome}",
      Charging, EngineRunning, batteryPercentage, CarHome);

    if (!ShouldBeCharging)
    {
      logger.LogDebug("Car should not be charging.");
      return;
    }

    logger.LogDebug("Car should be charging. Sending notification.");

    var start = new TimeSpan(8, 0, 0);
    var end = new TimeSpan(21, 30, 0);

    var notifyServices = new NotifyServices(haContext);

    notificationBuilder
      .SetMessage($"{batteryPercentage}% opladet")
      .SetTitle("Bilen lader ikke")
      .AddAction("Overblik", ActionUri.Lovelace("bil"), "car-not-charging")
      .SetChannel("alarm_stream")
      .MakeSticky()
      .SetColor(Color(batteryPercentage))
      .Notify(notifyServices.MobileAppKristoffersGalaxyS20Ultra);

    var now = DateTime.Now.TimeOfDay;

    if (now > start && now < end)
      notificationBuilder
        .MakeVoiceNotification($"Husk at sætte bilen til opladning. Den er i øjeblikket {batteryPercentage} procent opladet",
                               VoiceNotificationVolume.NotZero)
        .Notify(notifyServices.MobileAppKristoffersGalaxyS20Ultra);
  }
}