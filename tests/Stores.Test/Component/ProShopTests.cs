using FluentAssertions;
using Lerbaek.Stores.RegularExpressions.ProShop;
using Microsoft.Extensions.Logging;
using NMoneys;
using Xunit;
using Xunit.Abstractions;

namespace Lerbaek.Stores.Test.Component;

public class ProShopTests(ITestOutputHelper output) : StoreTestBase(output, GetProductId)
{
  private const string GalaxyS21Path = "/Mobil/Samsung-Galaxy-S21-5G-128GB-Phantom-Grey/2911936";
  private const string AirpodsPath    = "/Hovedtelefonerheadset/Apple-AirPods-2021/3011150";

  private static string GetProductId(Uri url, ILogger logger)
  {
    var validPath = url.TryGetProductId(out var productId, out var error);
    if (!validPath)
      logger.LogError(error);
    validPath.Should().BeTrue("the path should end with a product ID");
    return productId;
  }

  private ProShopModel CreateModel(string url) =>
    CreateModel<ProShopModel>(new Uri($"https://proshop.dk{url}"), ProShopModel.TryCreate);

  [Theory(Skip = "Archived")]
  [InlineData(GalaxyS21Path, "Samsung Galaxy S21 5G 128GB - Phantom Grey")]
  [InlineData(AirpodsPath, "Apple AirPods (2021)")]
  public async Task GetTitle_PageExists_TitleIsRetrieved(string url, string expectedTitle)
  {
    var uut = CreateModel(url);
    var title = await uut.GetTitle();
    title.Should().Be(expectedTitle);
  }


  [Theory(Skip = "Archived")]
  [InlineData(GalaxyS21Path, 4777)]
  [InlineData(AirpodsPath, 1333)]
  public async Task GetTitle_PageExists_CurrentPriceIsRetrieved(string url, decimal expectedCurrentPrice)
  {
    var uut = CreateModel(url);
    var price = await uut.GetCurrentPrice();
    price.Should().Be(expectedCurrentPrice);
  }


  [Theory(Skip = "Archived")]
  [InlineData(GalaxyS21Path, 6599)]
  [InlineData(AirpodsPath, 1495)]
  public async Task GetTitle_PageExists_NormalPriceIsRetrieved(string url, decimal expectedNormalPrice)
  {
    var uut = CreateModel(url);
    var price = await uut.GetNormalPrice();
    price.Should().Be(expectedNormalPrice);
  }


  [Theory(Skip = "Archived")]
  [InlineData(GalaxyS21Path)]
  [InlineData(AirpodsPath)]
  public void GetTitle_PageExists_CurrencyIsDKK(string url)
  {
    var uut = CreateModel(url);
    uut.Currency.Should().Be(CurrencyIsoCode.DKK);
  }
}