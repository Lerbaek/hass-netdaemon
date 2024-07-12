using Lerbaek.NetDaemon.Apps.Monitoring.PriceMonitor.StoreModels;
using Lerbaek.NetDaemon.Common;
using NetDaemon.Extensions.MqttEntityManager;

namespace Lerbaek.NetDaemon.Apps.Monitoring.PriceMonitor;

//[Focus]
[NetDaemonApp]
public class PriceMonitor : ServiceHandler
{
  private INetDaemonScheduler Scheduler { get; }
  private ILogger<PriceMonitor> Logger { get; }
  private HttpClient HttpClient { get; }
  private INotificationBuilder NotificationBuilder { get; }

  private IMqttEntityManager EntityManager { get; }

  public PriceMonitor(
    IHaContext haContext,
    INetDaemonScheduler scheduler,
    ILogger<PriceMonitor> logger,
    IHttpClientFactory httpClientFactory,
    INotificationBuilder notificationBuilder,
    IMqttEntityManager entityManager)
    : base(haContext, "pricemonitor")
  {
    EntityManager = entityManager;
    Scheduler = scheduler;
    Logger = logger;
    HttpClient = httpClientFactory.CreateClient(nameof(PriceMonitor));
    NotificationBuilder = notificationBuilder;
    entityManager.RemoveAsync("sensor.ilvapricemonitor_10557295642100692");
    //Initialize();
  }

  public record Registering(string? url);
  public record Unregistering(string? id);

  private void Initialize()
  {
    RegisterService<Registering>("register", Register);
    RegisterService<Unregistering>("unregister", Unregister);
  }

  private async Task Unregister(Unregistering args)
  {
    if (args.id is null)
    {
      Logger.LogError("No entity ID provided");
      return;
    }
    
    var entity = new Entity(haContext, args.id);
    if (entity.EntityState is null)
    {
      Logger.LogWarning("Entity {entityId} not found", args.id);
      return;
    }
    
    Logger.LogDebug("Removing {PriceMonitor} service with the id {Id}", nameof(PriceMonitor), args.id);
    await EntityManager.RemoveAsync(args.id!);

    entity.StateChanges().Subscribe(change =>
    {
      if (change.New is null)
        Logger.LogInformation("{Id} service removed.", args.id); //untested
    });
  }

  private async Task Register(Registering args)
  {
    if (args.url is null)
    {
      Logger.LogError("No URL provided");
      return;
    }

    if (!Uri.TryCreate(args.url, UriKind.Absolute, out var url))
    {
      Logger.LogError("Invalid URL provided");
      return;
    }

    IStorePriceMonitor? storePriceMonitor = null;
    var success = url.Host.ToLowerInvariant() switch
    {
      "ilva.dk" => IlvaPriceMonitor.TryCreate(url, HttpClient, Logger, out storePriceMonitor),
      "proshop.dk" => ProShopPriceMonitor.TryCreate(url, HttpClient, Logger, out storePriceMonitor),
      _ => false
    };
    
    if(!success)
    {
      Logger.LogError("Failed to create price monitor for the URL \"{url}\"", url);
      return;
    }

    var sensorEntity = new SensorEntity(haContext, storePriceMonitor!.EntityId);

    if(sensorEntity.State is null)
      await EntityManager.CreateAsync(storePriceMonitor.EntityId,
        new EntityCreationOptions
        {
          DeviceClass = "monetary",
          Name = await storePriceMonitor.GetTitle(),
          Persist = true,
        },
        new
        {
          icon = "mdi:chart-line",
          unit_of_measurement = $"{storePriceMonitor.Currency}"
        });

    Scheduler.RunEvery(FromHours(1), () => Watch(storePriceMonitor).Wait());
    await Watch(storePriceMonitor);
  }

  private async Task Watch(IStorePriceMonitor storePriceMonitor)
  {
    storePriceMonitor.Refresh();
    var title = await storePriceMonitor.GetTitle();
    var price = await storePriceMonitor.GetCurrentPrice();

    var oldPriceFound = decimal.TryParse(new SensorEntity(haContext, storePriceMonitor.EntityId).State, out var oldPrice);
    if (oldPriceFound)
    {
      if (price == oldPrice)
      {
        Logger.LogTrace("{title}: {currency}{price} (unchanged)", title, storePriceMonitor.Currency, price);
        return;
      }
    }

    var normalPrice = await storePriceMonitor.GetNormalPrice();

    if (price != normalPrice)
      Logger.LogInformation("{title}: {currency}{price} (normally {currency}{normalPrice})",
        title, storePriceMonitor.Currency, price, storePriceMonitor.Currency,
        await storePriceMonitor.GetNormalPrice());
    else
      Logger.LogInformation("{title}: {currency}{price}",
        title, storePriceMonitor.Currency, price);

    await EntityManager.SetStateAsync(storePriceMonitor.EntityId, $"{price}");
  }
}