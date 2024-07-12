using Lerbaek.Stores;

namespace Lerbaek.NetDaemon.Apps.Monitoring.PriceMonitor.StoreModels;

public class IlvaPriceMonitor : IlvaModel, IStorePriceMonitor
{
  public string EntityId { get; }

  private IlvaPriceMonitor(string productItemId, string variantErpId, HttpClient httpClient, ILogger logger)
    : base(productItemId, variantErpId, httpClient, logger) =>
    EntityId = $"sensor.{nameof(IlvaPriceMonitor).ToLowerInvariant()}_{productItemId}_{variantErpId}";

  public static bool TryCreate(Uri url, HttpClient httpClient, ILogger logger, out IStorePriceMonitor? instance) =>
    TryCreate(url, logger, (productItemId, variantErpId) =>
      new IlvaPriceMonitor(productItemId, variantErpId, httpClient, logger), out instance);

}