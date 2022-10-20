using System.Threading.Tasks;
using NMoneys;

namespace Lerbaek.Stores
{
  public interface IStoreModel
  {
    Task<decimal> GetCurrentPrice();
    Task<decimal> GetNormalPrice();
    Task<string> GetTitle();
    CurrencyIsoCode Currency { get; }
    void Refresh();
  }
}