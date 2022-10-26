using FluentValidation.TestHelper;
using Lerbaek.NetDaemon.Common.Logging;

namespace Lerbaek.NetDaemon.Apps.Automations.ChestFreezer;

[NetDaemonApp]
//[Focus]
public class ChestFreezer
{
  private readonly INetDaemonScheduler scheduler;
  private readonly ILogger<ChestFreezer> logger;
  private readonly INotificationBuilder notificationBuilder;
  private readonly NumericSensorEntity nordpoolSensor;
  private readonly SwitchEntity chestFreezer;
  private readonly InputBooleanEntity chestFreezerPaused;
  private readonly NotifyServices notifyServices;

  public ChestFreezer(IHaContext ha, INetDaemonScheduler scheduler, ILogger<ChestFreezer> logger, INotificationBuilder notificationBuilder)
  {
    this.scheduler = scheduler;
    this.logger = logger;
    this.notificationBuilder = notificationBuilder;
    var entities = new Entities(ha);
    notifyServices = new NotifyServices(ha);
    nordpoolSensor = entities.Sensor.NordpoolKwhDk1Dkk310025;
    chestFreezer = entities.Switch.Kummefryser;
    chestFreezerPaused = entities.InputBoolean.KummefryserPaPause;
    Task.Run(SetPowerState);
  }

  private void SetPowerState()
  {
    try
    {
      if (!nordpoolSensor.State.HasValue)
        throw new NullReferenceException($"Ingen øjebliksværdi fundet i {nordpoolSensor.EntityId}");
      var thresholds = EvaluateThresholds;

      var currentPrice = nordpoolSensor.State!.Value;
      var needsToggling = currentPrice > thresholds.High && chestFreezer.IsOn() ||
                          currentPrice < thresholds.Low && chestFreezer.IsOff();
      var tooHigh = needsToggling ^ chestFreezer.IsOff();

      if (needsToggling)
      {
        logger.LogInformation("{TurningOnOrOff} kummefryseren.", tooHigh ? "Slukker" : "Tænder");
        SetStateOn(chestFreezerPaused, tooHigh);
        SetStateOn(chestFreezer, !tooHigh);
      }
      else
        logger.LogInformation("Kummefryseren er fortsat {onOrOff}.", tooHigh ? "slukket" : "tændt");

      var attributes = nordpoolSensor.Attributes!;

      var knownPrices = attributes
        .Today!
        // ReSharper disable once RedundantEnumerableCastCall
        // If regenerated when no values are available for tomorrow, type will be Object
        .Concat(attributes.Tomorrow!.OfType<double>())
        .ToArray();

      var nextHour = DateTime.Now.Hour + 1;

      var knownFuturePrices = knownPrices
        .Skip(nextHour)
        .ToList();

      var pricesOutsideThreshold = knownFuturePrices
        .Where(price =>
          tooHigh
            ? price < thresholds.Low
            : price > thresholds.High)
        .ToArray();

      if (pricesOutsideThreshold.Any())
      {
        var acceptablePriceTime = (knownFuturePrices.IndexOf(pricesOutsideThreshold.First()) + nextHour) % 24;
        logger.LogInformation("Den {onOrOff} igen kl. {time}", tooHigh ? "tændes" : "slukkes", acceptablePriceTime);
      }
      else
      {
        logger.LogInformation("Der er ikke planlagt ændringer i de næste {availableHours} timer.",
          knownFuturePrices.Count.ToString());
      }
    }
    catch(Exception e)
    {
      logger.LogErrorMethod(e);
      if (chestFreezer.IsOff())
      {
        logger.LogWarning("Tænder fryseren for en sikkerheds skyld.");
        chestFreezer.TurnOn();
      }
      notificationBuilder.Presets.NotifyAppException(e);
    }
    finally
    {
      ScheduleNextRun();
    }
  }

  private (double Low, double High) EvaluateThresholds
  {
    get
    {
      {
        var currentPriceString = FormatPrice(nordpoolSensor.State!.Value);
        IReadOnlyList<double>? pricesToday = null;
        var retriesLeft = 16;
        while(retriesLeft --> 1)
        {
          try
          {
            pricesToday = nordpoolSensor.Attributes!.Today!;
            break;
          }
          catch (Exception e)
          {
            if (retriesLeft == 0)
              throw;
            notificationBuilder.Presets.NotifyAppException(e);
            logger.LogErrorMethod(e);
            logger.LogWarning("Retrying every minute for {retries} more minute(s). Debugging is encouraged.", retriesLeft);
            Task.Delay(FromMinutes(1)).Wait();
          }
        }
        var lowerThreshold = pricesToday!.OrderBy(_ => _).Skip(11).Take(2).Average();
        var average = pricesToday!.Average();
        var upperThreshold = new[]{lowerThreshold, average, 1}.Max(); // Never turn off if below 1
        var lowerString = FormatPrice(lowerThreshold);
        var upperString = FormatPrice(upperThreshold);
        logger.LogInformation("1 kWh koster nu {currentPrice}.", currentPriceString);
        logger.LogInformation("Tænder når prisen er under: {low}.", lowerString);
        logger.LogInformation("Slukker når den er over: {high}", upperString);
        return (lowerThreshold, upperThreshold);
      }
    }
  }

  private string FormatPrice(double price)
  {
    var priceKroner = (int)price;
    var priceKronerString = priceKroner > 0 ? priceKroner + " kr." : "";
    var priceOre = (int)Math.Round(price % 1 * 100);
    var priceOreString = priceOre > 0 ? priceOre + " øre" : "";
    var priceString = string.Join(" og ", new[] { priceKronerString, priceOreString }.Where(p => !string.IsNullOrEmpty(p)));
    return priceString;
  }

  private void SetStateOn(Entity entity, bool turnedOn) =>
    entity.CallService($"turn_{(turnedOn ? "on" : "off")}");

  private void ScheduleNextRun()
  {
    var now = DateTime.Now;
    var nextRun = now
      .AddHours(1)
      .AddMinutes(0 - now.Minute)
      .AddSeconds(5 - now.Second)
      .AddMilliseconds(0 - now.Millisecond);
    scheduler.RunAt(nextRun, SetPowerState);
  }
}