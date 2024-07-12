using Lerbaek.Stores;

namespace Lerbaek.NetDaemon.Apps.Monitoring.PriceMonitor.StoreModels;

public interface IStorePriceMonitor : IStoreModel
{
  string EntityId { get; }
}