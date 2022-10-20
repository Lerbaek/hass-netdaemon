using NetDaemon.Extensions.MqttEntityManager;

namespace Lerbaek.NetDaemon.Apps.Automations;

//[NetDaemonApp]
//[Focus]
public class EconomicCarCharge
{
  private readonly IHaContext ha;
  private readonly ILogger<EconomicCarCharge> logger;
  private readonly IMqttEntityManager mqttEntityManager;

  private readonly Entities entities;
  private readonly NumericSensorEntity nordpool;

  public EconomicCarCharge(IHaContext ha, ILogger<EconomicCarCharge> logger, IMqttEntityManager mqttEntityManager)
  {
    this.ha = ha;
    this.logger = logger;
    this.mqttEntityManager = mqttEntityManager;
    entities = new Entities(ha);
    nordpool = entities.Sensor.NordpoolKwhDk1Dkk310025;

    entities
      .BinarySensor
      .CeedCharging
      .StateChanges()
      .Subscribe(AdjustCharging);

    nordpool
      .StateChanges()
      .Subscribe(AdjustCharging);
  }

  private void AdjustCharging(StateChange<BinarySensorEntity, EntityState<BinarySensorAttributes>> obj) =>
    AdjustCharging();

  private void
    AdjustCharging(NumericStateChange<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>> obj) =>
    AdjustCharging();

  private void AdjustCharging()
  {
    var charge = (int)entities.Sensor.CeedEvBattery.State!;
    if (charge == 100)
      return;

    var attributes = nordpool.Attributes!;
    var deadline = TimeOnly.Parse(entities.InputDatetime.BagkantForBilopladning.State!);

    var today = attributes.Today!
      .Where((_, time) => time < DateTime.Now.Hour)
      .Select((price, time) => (price, time))
      .ToDictionary(time => time.time, price => price.price);

    var tomorrow = attributes.Tomorrow!
      .Select((price, time) => (price, time))
      .ToDictionary(time => time.time, price => price.price);


  }
}