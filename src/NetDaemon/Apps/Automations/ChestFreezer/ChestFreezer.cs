using Lerbaek.NetDaemon.Common.Logging;

namespace Lerbaek.NetDaemon.Apps.Automations.ChestFreezer;

[NetDaemonApp]
//[Focus]
public class ChestFreezer
{
  private readonly INetDaemonScheduler _scheduler;
  private readonly ILogger<ChestFreezer> _logger;
  private readonly INotificationBuilder _notificationBuilder;
  private readonly NumericSensorEntity _energySensor;
  private readonly SwitchEntity _chestFreezer;
  private readonly InputBooleanEntity _chestFreezerPaused;

  public ChestFreezer(IHaContext ha, INetDaemonScheduler scheduler, ILogger<ChestFreezer> logger, INotificationBuilder notificationBuilder)
  {
    _scheduler = scheduler;
    _logger = logger;
    _notificationBuilder = notificationBuilder;
    var entities = new Entities(ha);
    _energySensor = entities.Sensor.EnergiDataService;
    _chestFreezer = entities.Switch.Kummefryser;
    _chestFreezerPaused = entities.InputBoolean.KummefryserPaPause;
    Task.Run(SetPowerState);
  }

  private void SetPowerState()
  {
    try
    {
      if (!_energySensor.State.HasValue)
        throw new NullReferenceException($"Ingen øjebliksværdi fundet i {_energySensor.EntityId}");
      var (low, high) = EvaluateThresholds;

      var currentPrice = _energySensor.State!.Value;
      var needsToggling = currentPrice > high && _chestFreezer.IsOn() ||
                          currentPrice < low && _chestFreezer.IsOff();
      var tooHigh = needsToggling ^ _chestFreezer.IsOff();

      if (needsToggling)
      {
        _logger.LogInformation("{TurningOnOrOff} kummefryseren.", tooHigh ? "Slukker" : "Tænder");
        SetStateOn(_chestFreezerPaused, tooHigh);
        SetStateOn(_chestFreezer, !tooHigh);
      }
      else
        _logger.LogInformation("Kummefryseren er fortsat {OnOrOff}.", tooHigh ? "slukket" : "tændt");

      var attributes = _energySensor.Attributes!;

      var knownPrices = attributes
        .Today!
        .Concat(attributes.Tomorrow is IEnumerable<double> tomorrow ? tomorrow : [])
        .ToArray();

      var nextHour = DateTime.Now.Hour + 1;

      var knownFuturePrices = knownPrices
        .Skip(nextHour)
        .ToList();

      var pricesOutsideThreshold = knownFuturePrices
        .Where(price =>
          tooHigh
            ? price < low
            : price > high)
        .ToArray();

      if (pricesOutsideThreshold.Length != 0)
      {
        var acceptablePriceTime = (knownFuturePrices.IndexOf(pricesOutsideThreshold.First()) + nextHour) % 24;
        _logger.LogInformation("Den {OnOrOff} igen kl. {Time}", tooHigh ? "tændes" : "slukkes", acceptablePriceTime);
      }
      else
      {
        _logger.LogInformation("Der er ikke planlagt ændringer i de næste {AvailableHours} timer.",
          knownFuturePrices.Count.ToString());
      }
    }
    catch(Exception e)
    {
      _logger.LogErrorMethod(e);
      if (_chestFreezer.IsOff())
      {
        _logger.LogWarning("Tænder fryseren for en sikkerheds skyld.");
        _chestFreezer.TurnOn();
      }

      _notificationBuilder.Presets.NotifyAppException(e);
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
        var currentPriceString = FormatPrice(_energySensor.State!.Value);
        IReadOnlyList<double>? pricesToday = null;
        var retriesLeft = 16;
        while(retriesLeft --> 1)
        {
          try
          {
            pricesToday = _energySensor.Attributes!.Today!;
            break;
          }
          catch (Exception e)
          {
            if (retriesLeft == 0)
              throw;
            _notificationBuilder.Presets.NotifyAppException(e);
            _logger.LogErrorMethod(e);
            _logger.LogWarning("Retrying every minute for {Retries} more minute(s). Debugging is encouraged.", retriesLeft);
            Task.Delay(FromMinutes(1)).Wait();
          }
        }

        var lowerThreshold = pricesToday!.OrderBy(_ => _).Skip(11).Take(2).Average();
        var average = pricesToday!.Average();
        var upperThreshold = new[]{lowerThreshold, average, 2.5}.Max(); // Never turn off if below 2,5
        var lowerString = FormatPrice(lowerThreshold);
        var upperString = FormatPrice(upperThreshold);
        _logger.LogInformation("1 kWh koster nu {CurrentPrice}.", currentPriceString);
        _logger.LogInformation("Tænder når prisen er under: {Low}.", lowerString);
        _logger.LogInformation("Slukker når den er over: {High}", upperString);
        return (lowerThreshold, upperThreshold);
      }
    }
  }

  private static string FormatPrice(double price)
  {
    var priceKroner = (int)price;
    var priceKronerString = priceKroner > 0 ? priceKroner + " kr." : "";
    var priceOre = (int)Math.Round(price % 1 * 100);
    var priceOreString = priceOre > 0 ? priceOre + " øre" : "";
    var priceString = string.Join(" og ", new[] { priceKronerString, priceOreString }.Where(p => !string.IsNullOrEmpty(p)));
    return priceString;
  }

  private static void SetStateOn(Entity entity, bool turnedOn) =>
    entity.CallService($"turn_{(turnedOn ? "on" : "off")}");

  private void ScheduleNextRun()
  {
    var now = DateTime.Now;
    var nextRun = now
      .AddHours(1)
      .AddMinutes(0 - now.Minute)
      .AddSeconds(5 - now.Second)
      .AddMilliseconds(0 - now.Millisecond);
    _scheduler.RunAt(nextRun, SetPowerState);
  }
}