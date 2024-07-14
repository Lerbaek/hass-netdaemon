using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Lerbaek.Stores.RegularExpressions.ProShop;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using NMoneys;
using RegExtract;

namespace Lerbaek.Stores
{
  public class ProShopModel : StoreModel, IStoreModel
  {
    private readonly HttpClient _httpClient;
    private Task<JToken> _content;

    protected string ProductId { get; }

    protected ProShopModel(string productId, HttpClient httpClient, ILogger logger) : base(logger)
    {
      ProductId = productId;
      _httpClient = httpClient;
      Refresh();
    }

    public static bool TryCreate(Uri url, HttpClient httpClient, ILogger logger, out ProShopModel instance) =>
      TryCreate(url, logger, productId =>
        new ProShopModel(productId, httpClient, logger), out instance);

    public static bool TryCreate<TModel>(Uri url, ILogger logger, Func<string, TModel> constructor, out TModel instance)
    {
      try
      {
        var success = true;
        if(!url.TryGetProductId(out var productId, out var error))
        {
          success = false;
          logger.LogError(error);
        }

        instance = success
          ? constructor(productId)
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
      const string titleKey = "ProductName";
      var token = await _content;
      var title = token[titleKey]?.Value<string>()?.Trim() ?? throw new KeyNotFoundException(titleKey);
      Logger.LogDebug($"{titleKey}: {title}");
      return title;
    }

    public CurrencyIsoCode Currency => CurrencyIsoCode.DKK;

    public void Refresh()
    {
      const string baseUrl =
        "https://proshop.dk/";
      
      _content = Task.Run(async () =>
      {
        var requestUri = $"{baseUrl}{ProductId}";
        var response = await _httpClient.GetAsync(requestUri);
        var responseContent = await response.Content.ReadAsStringAsync();
        try
        {
          var json = responseContent.Extract<string>("var item = ([^;]*)") ?? throw new InvalidOperationException();
          return JToken.Parse(json);
        }
        catch (Exception e)
        {
          Logger.LogError(e, "An error occurred while parsing JSON string from {requestUri}", requestUri);
          throw;
        }
      });
    }

    public async Task<decimal> GetCurrentPrice() => await GetPrice("Price");

    public async Task<decimal> GetNormalPrice() => await GetPrice("Old_price");

    protected async Task<decimal> GetPrice(string priceTypeKey)
    {
      var token = await _content;
      var value = token[priceTypeKey]?.Value<decimal>() ?? throw new KeyNotFoundException(priceTypeKey);
      Logger.LogDebug($"{priceTypeKey}: {value}");
      return value;
    }
  }
}