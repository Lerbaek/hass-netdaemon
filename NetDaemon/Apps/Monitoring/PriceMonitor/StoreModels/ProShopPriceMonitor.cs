using Lerbaek.Stores;

namespace Lerbaek.NetDaemon.Apps.Monitoring.PriceMonitor.StoreModels;

public class ProShopPriceMonitor : ProShopModel, IStorePriceMonitor
{
  public string EntityId { get; }

  private ProShopPriceMonitor(string productId, HttpClient httpClient, ILogger logger)
    : base(productId, httpClient, logger) =>
    EntityId = $"sensor.{nameof(ProShopPriceMonitor).ToLowerInvariant()}_{productId}";

  public static bool TryCreate(Uri url, HttpClient httpClient, ILogger logger, out IStorePriceMonitor? instance) =>
    TryCreate(url, logger, productId =>
      new ProShopPriceMonitor(productId, httpClient, logger), out instance);

}