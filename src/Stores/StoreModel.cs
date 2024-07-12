using Microsoft.Extensions.Logging;

namespace Lerbaek.Stores
{
  public abstract class StoreModel
  {
    protected ILogger Logger { get; }

    protected StoreModel(ILogger logger) => Logger = logger;
  }
}