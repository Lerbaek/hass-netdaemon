namespace Lerbaek.NetDaemon.Apps.Alarms.CarNotChargingAlarm;

/// <summary>
///   Application to perform repetitive voice alarms.
/// </summary>
//[Focus]
//[NetDaemonApp]
public class CarNotChargingAlarmApp
{
  private const string CarBluetoothMacAddress = "CC:88:26:8E:E0:52";
  private readonly IHaContext _haContext;
  private readonly ILogger<CarNotChargingAlarmApp> _logger;
  private readonly INotificationBuilder _notificationBuilder;
  private readonly Entities _entities;
  private readonly Services _services;
  private string _carBluetoothName = null!;

  private readonly string[] _homeNetworks =
  [
    "Virus.exe",
    "Virus5.ext",
    "Virus.ext",
    "PlayGroundStuff"
  ];

  private bool EngineRunning => _entities.BinarySensor.CeedEngine.IsOn();
  private bool Connected => ChargerSeesCar || CarSeesCharger;
  private bool ChargerSeesCar => !DescriptionContains("disconnected") && (DescriptionContains("connected") || DescriptionContains("charging"));
  private bool CarSeesCharger => _entities.BinarySensor.CeedEvBatteryPlug.IsOn();
  private bool CarHome => IsHome(_entities.DeviceTracker.CeedLocation);
  private bool KristofferHome => IsHome(_entities.Person.Kristoffer) || KristofferConnectedToHomeNetwork;
  private bool KristofferConnectedToHomeNetwork => IsConnectedToHomeNetwork(_entities.Sensor.KristoffersGalaxyS20UltraWifiConnection);
  //private bool GroConnectedToHomeNetwork => IsConnectedToHomeNetwork(entities.Sensor.GrosGalaxyS20WifiConnection);

  private bool DescriptionContains(string key) => _entities.Sensor.WallboxPortalStatusDescription.State!.Contains(key, StringComparison.InvariantCultureIgnoreCase);
  private bool BatteryIs(int percentage) => (int)Math.Round(_entities.Sensor.CeedEvBatteryLevel.State!.Value) == percentage;
  private static bool IsHome(Entity entity) => entity.State is "home";

  private bool IsConnectedToCarBluetooth(NumericEntityState<NumericSensorAttributes> entity)
  {
    if(entity.Attributes!.ConnectedPairedDevices is IEnumerable<string> devices)
      return devices.Contains(_carBluetoothName);
    return false;
  }

  private bool IsConnectedToHomeNetwork(SensorEntity sensor) => _homeNetworks.Contains(sensor.State!);

  private bool CarDisconnected(NumericStateChange<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>> change) =>
    IsConnectedToCarBluetooth(change.Old!) && !IsConnectedToCarBluetooth(change.New!);

  private bool ShouldBeCharging => !Connected && !EngineRunning && !BatteryIs(0) && !BatteryIs(100) && CarHome;

  private static Color Color(int percentage)
  {
    var multiplier = 1.0 / Math.Max(percentage, 100 - percentage) * 255;
    return FromArgb((int)Math.Round((100 - percentage) * multiplier), (int)Math.Round(percentage * multiplier), 0);
  }

  private void ForceUpdate() => _services.KiaUvo.ForceUpdate("74bce309438a261af1845811fb2599d5");

  public CarNotChargingAlarmApp(IHaContext haContext, ILogger<CarNotChargingAlarmApp> logger, INotificationBuilder notificationBuilder)
  {
    _haContext = haContext;
    _logger = logger;
    _notificationBuilder = notificationBuilder;
    _entities = new Entities(haContext);
    _services = new Services(haContext);
    _entities.Sensor.CeedLastUpdatedAt.StateChanges().Subscribe(CarNotChargingAlarm);
    ForceUpdate();
    ConfigureHomeArrival();
  }

  private void ConfigureHomeArrival()
  {
    _carBluetoothName =
      _entities
        .Sensor
        .KristoffersGalaxyS20UltraBluetoothConnection
        .Attributes!
        .PairedDevices!
        .Single(d => d.Contains(CarBluetoothMacAddress, StringComparison.InvariantCultureIgnoreCase));

    _logger.LogInformation("Car's Bluetooth name resolved to {bluetoothName}", _carBluetoothName);

    var people = new (NumericSensorEntity BluetoothConnection, Func<bool> IsHome)[]
    {
      (BluetoothConnection: _entities.Sensor.KristoffersGalaxyS20UltraBluetoothConnection, () => KristofferHome),
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
          _logger.LogDebug(
            "{friendlyName} has disconnected from {bluetoothName}, but the phone has been detected away from home.",
            change.Entity.Attributes!.FriendlyName,
            _carBluetoothName);
          return;
        }

        _logger.LogInformation(
          "{friendlyName} has disconnected from {bluetoothName}, and the phone has been detected at home. Refreshing data.",
          change.Entity.Attributes!.FriendlyName,
          _carBluetoothName);

        ForceUpdate();
      });
  }


  private void CarNotChargingAlarm(StateChange<SensorEntity, EntityState<SensorAttributes>> change)
  {
    _logger.LogInformation("Evaluating charging status.");

    _ = Policy.HandleResult<NumericSensorEntity>(entity => !entity.State.HasValue)
      .WaitAndRetry(Backoff.ExponentialBackoff(FromSeconds(1), 5),
        (_, _, retryCount, _) =>
        {
          _logger.LogDebug("Entities not yet available.");
          _logger.LogDebug("Retry count: {RetryCount}.", retryCount);
        }).ExecuteAndCapture(() => _entities.Sensor.CeedEvBatteryLevel);

    Task.Delay(5000).Wait();

    if (!_entities.Sensor.CeedEvBatteryLevel.State.HasValue)
    {
      _logger.LogWarning("Charging status could not be determined, entities are unavailable.");
      return;
    }

    var batteryPercentage = (int)Math.Round(_entities.Sensor.CeedEvBatteryLevel.State!.Value);

    _logger.LogDebug(
      """
        Connected: {Connected}
        Engine running: {EngineRunning}
        Battery: {BatteryPercentage}%
        Car is home: {CarHome}
      """,
      Connected, EngineRunning, batteryPercentage, CarHome);

    var notifyServices = new NotifyServices(_haContext);

    if (!ShouldBeCharging)
    {
      _logger.LogDebug("Car should not be charging.");
      NotificationBuilder.Clear(nameof(CarNotChargingAlarm), notifyServices.KristoffersTelefon);
      return;
    }

    _logger.LogDebug("Car should be charging. Sending notification.");

    var start = new TimeSpan(8, 0, 0);
    var end = new TimeSpan(21, 30, 0);

    _notificationBuilder
      .SetMessage($"{batteryPercentage}% opladet")
      .SetTitle("Bilen lader ikke")
      .AddActionUri("Overblik", ActionUri.Lovelace("bil"), "car-not-charging")
      .SetChannel("alarm_stream")
      .MakeSticky()
      .SetTag(nameof(CarNotChargingAlarm))
      .SetColor(Color(batteryPercentage))
      .Notify(notifyServices.KristoffersTelefon);

    var now = DateTime.Now.TimeOfDay;

    if (now > start && now < end && KristofferHome)
      _notificationBuilder
        .MakeVoiceNotification($"Husk at sætte bilen til opladning. Den er i øjeblikket {batteryPercentage} procent opladet",
                               VoiceNotificationVolume.NotZero)
        .Notify(notifyServices.KristoffersTelefon);
  }
}