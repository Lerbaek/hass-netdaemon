namespace Lerbaek.NetDaemon.Apps.Alarms.CarNotChargingAlarm;

/// <summary>
///   Application to perform repetitive voice alarms.
/// </summary>
//[Focus]
[NetDaemonApp]
public class CarNotChargingAlarmApp
{
  private const string CarBluetoothMacAddress = "CC:88:26:8E:E0:52";
  private readonly IHaContext haContext;
  private readonly ILogger<CarNotChargingAlarmApp> logger;
  private readonly INotificationBuilder notificationBuilder;
  private readonly Entities entities;
  private string carBluetoothName = null!;

  private readonly string[] homeNetworks =
  {
    "Virus.exe",
    "Virus5.ext",
    "Virus.ext",
    "PlayGroundStuff"
  };

  private bool EngineRunning => entities.BinarySensor.CeedEngine.IsOn();
  private bool Connected => ChargerSeesCar || CarSeesCharger;
  private bool ChargerSeesCar => DescriptionContains("connected") || DescriptionContains("charging");
  private bool CarSeesCharger => entities.BinarySensor.CeedPluggedIn.IsOn();
  private bool CarHome => IsHome(entities.DeviceTracker.CeedLocation);
  private bool KristofferHome => IsHome(entities.Person.Kristoffer) || KristofferConnectedToHomeNetwork;
  private bool KristofferConnectedToHomeNetwork => IsConnectedToHomeNetwork(entities.Sensor.KristoffersGalaxyS20UltraWifiConnection);
  //private bool GroConnectedToHomeNetwork => IsConnectedToHomeNetwork(entities.Sensor.GrosGalaxyS20WifiConnection);

  private bool DescriptionContains(string key) => entities.Sensor.WallboxPortalStatusDescription.State!.Contains(key, StringComparison.InvariantCultureIgnoreCase);
  private bool BatteryIs(int percentage) => (int)Math.Round(entities.Sensor.CeedEvBattery.State!.Value) == percentage;
  private bool IsHome(Entity entity) => entity.State is "home";

  private bool IsConnectedToCarBluetooth(NumericEntityState<NumericSensorAttributes> entity) =>
    entity.Attributes!
      .ConnectedPairedDevices!
      .Contains(carBluetoothName);

  private bool IsConnectedToHomeNetwork(SensorEntity sensor) => homeNetworks.Contains(sensor.State!);

  private bool CarDisconnected(NumericStateChange<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>> change) =>
    IsConnectedToCarBluetooth(change.Old!) && !IsConnectedToCarBluetooth(change.New!);

  private bool ShouldBeCharging => !Connected && !EngineRunning && !BatteryIs(0) && !BatteryIs(100) && CarHome;

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
    entities.Sensor.CeedLastUpdate.StateChanges().Subscribe(CarNotChargingAlarm);
    entities.Switch.CeedForceUpdate.TurnOn();
    ConfigureHomeArrival();
  }

  private void ConfigureHomeArrival()
  {
    carBluetoothName =
      entities
        .Sensor
        .KristoffersGalaxyS20UltraBluetoothConnection
        .Attributes!
        .PairedDevices!
        .Single(d => d.Contains(CarBluetoothMacAddress, StringComparison.InvariantCultureIgnoreCase));

    logger.LogInformation("Car's Bluetooth name resolved to {bluetoothName}", carBluetoothName);

    var people = new (NumericSensorEntity BluetoothConnection, Func<bool> IsHome)[]
    {
      (BluetoothConnection: entities.Sensor.KristoffersGalaxyS20UltraBluetoothConnection, () => KristofferHome),
      //(entities.Sensor.GrosGalaxyS20BluetoothConnection, () => GroHome),
    };

    foreach (var person in people)
      person.BluetoothConnection
        .StateAllChanges()
        .Subscribe(change =>
      {
        if (!CarDisconnected(change))
          return;

        if (!person.IsHome())
        {
          logger.LogDebug(
            "{friendlyName} has disconnected from {bluetoothName}, but the phone has been detected away from home.",
            change.Entity.Attributes!.FriendlyName,
            carBluetoothName);
          return;
        }

        logger.LogInformation(
          "{friendlyName} has disconnected from {bluetoothName}, and the phone has been detected at home. Refreshing data.",
          change.Entity.Attributes!.FriendlyName,
          carBluetoothName);

        entities.Switch.CeedForceUpdate.TurnOn();
      });
  }


  private void CarNotChargingAlarm(StateChange<SensorEntity, EntityState<SensorAttributes>> change)
  {
    logger.LogInformation("Evaluating charging status.");

    _ = Policy.HandleResult<NumericSensorEntity>(entity => !entity.State.HasValue)
      .WaitAndRetry(Backoff.ExponentialBackoff(FromSeconds(1), 5),
        (_, _, retryCount, _) =>
        {
          logger.LogDebug("Entities not yet available.");
          logger.LogDebug("Retry count: {RetryCount}.", retryCount);
        }).ExecuteAndCapture(() => entities.Sensor.CeedEvBattery);

    Task.Delay(5000).Wait();

    if (!entities.Sensor.CeedEvBattery.State.HasValue)
    {
      logger.LogWarning("Charging status could not be determined, entities are unavailable.");
      return;
    }

    var batteryPercentage = (int)Math.Round(entities.Sensor.CeedEvBattery.State!.Value);

    logger.LogDebug(@"
Connected: {Connected}
Engine running: {EngineRunning}
Battery: {BatteryPercentage}%
Car is home: {CarHome}",
      Connected, EngineRunning, batteryPercentage, CarHome);

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
      .AddActionUri("Overblik", ActionUri.Lovelace("bil"), "car-not-charging")
      .SetChannel("alarm_stream")
      .MakeSticky()
      .SetColor(Color(batteryPercentage))
      .Notify(notifyServices.MobileAppKristoffersGalaxyS20Ultra);

    var now = DateTime.Now.TimeOfDay;

    if (now > start && now < end && KristofferHome)
      notificationBuilder
        .MakeVoiceNotification($"Husk at sætte bilen til opladning. Den er i øjeblikket {batteryPercentage} procent opladet",
                               VoiceNotificationVolume.NotZero)
        .Notify(notifyServices.MobileAppKristoffersGalaxyS20Ultra);
  }
}