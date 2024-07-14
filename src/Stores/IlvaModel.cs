using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lerbaek.Stores.RegularExpressions.Ilva;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using NMoneys;

namespace Lerbaek.Stores
{
  public class IlvaModel : StoreModel, IStoreModel
  {
    private readonly string _productItemId;
    private readonly string _variantErpId;
    private readonly HttpClient _httpClient;
    private Task<JToken> _content;
  
    protected string ProductId => $"{_productItemId}-{_variantErpId}";

    protected IlvaModel(string productItemId, string variantErpId, HttpClient httpClient, ILogger logger) : base(logger)
    {
      _productItemId = productItemId;
      _variantErpId = variantErpId;
      _httpClient = httpClient;
      Refresh();
    }

    public static bool TryCreate(Uri url, HttpClient httpClient, ILogger logger, out IlvaModel instance) =>
      TryCreate(url, logger, (productItemId, variantErpId) =>
        new IlvaModel(productItemId, variantErpId, httpClient, logger), out instance);

    public static bool TryCreate<TModel>(Uri url, ILogger logger, Func<string, string, TModel> constructor, out TModel instance)
    {
      try
      {
        var success = true;
        if(!url.TryGetProductItemId(out var productItemId, out var error))
        {
          success = false;
          logger.LogError(error);
        }

        if(!url.TryGetVariantErp(out var variantErpId, out error))
        {
          success = false;
          logger.LogError(error);
        }

        instance = success
          ? constructor(productItemId, variantErpId)
          : default;

        return success;
      }
      catch(Exception e)
      {
        logger.LogError(e, e.Message);
        instance = default;
        return false;
      }
    }

    public async Task<string> GetTitle()
    {
      const string titleKey = "title";
      
      var variant = await GetVariantToken();
      var title = variant[titleKey]?.Value<string>()?.Trim() ?? throw new KeyNotFoundException(titleKey);
      Logger.LogDebug($"{titleKey}: {title}");
      return title;
    }

    public CurrencyIsoCode Currency => CurrencyIsoCode.DKK;

    public void Refresh()
    {
      const string baseUrl =
        "https://ilva.dk/umbraco/frontend/productapi/GetProducts?ExcludeDiscountedVariants=false&productIds=";
      
      _content = Task.Run(async () =>
      {
        var response = await _httpClient.GetAsync($"{baseUrl}{ProductId}");
        var responseContent = await response.Content.ReadAsStringAsync();
        return JToken.Parse(responseContent);
      });
    }

    public async Task<decimal> GetCurrentPrice() => await GetPrice("total");

    public async Task<decimal> GetNormalPrice() => await GetPrice("unitPrice");

    private async Task<decimal> GetPrice(string priceTypeKey)
    {
      const string priceKey = "price";
      const string valueKey = "value";
      
      var variant = await GetVariantToken();
      var price = variant[priceKey] ?? throw new KeyNotFoundException(priceKey);
      var priceType = price[priceTypeKey] ?? throw new KeyNotFoundException(priceTypeKey);
      var value = priceType[valueKey]?.Value<decimal>() ?? throw new KeyNotFoundException(valueKey);
      Logger.LogDebug($"{priceTypeKey}: {value}");
      return value;
    }

    private async Task<JToken> GetVariantToken()
    {
      const string dataKey = "data";
      const string variantsKey = "variants";

      var jToken = await _content;
      var data = jToken[dataKey] ?? throw new KeyNotFoundException(dataKey);
      var firstData = data[0] ?? throw new InvalidOperationException($"\"{dataKey}\" is empty or not an array");
      var variants = firstData[variantsKey] ?? throw new KeyNotFoundException(variantsKey);
      var variant = variants.Single(v => v[nameof(_variantErpId)].Value<string>() == _variantErpId);
      return variant;
    }
  }
}