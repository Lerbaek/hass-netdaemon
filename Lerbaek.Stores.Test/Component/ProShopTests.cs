using FluentAssertions;
using Lerbaek.Stores.RegularExpressions.ProShop;
using Microsoft.Extensions.Logging;
using NMoneys;
using Xunit;
using Xunit.Abstractions;

namespace Lerbaek.Stores.Test.Component;

public class ProShopTests : StoreTestBase
{
  private const string galaxyS21Path = "/Mobil/Samsung-Galaxy-S21-5G-128GB-Phantom-Grey/2911936";
  private const string airpodsPath    = "/Hovedtelefonerheadset/Apple-AirPods-2021/3011150";

  public ProShopTests(ITestOutputHelper output) : base(output, GetProductId) { }
  
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

  [Theory]
  [InlineData(galaxyS21Path, "Samsung Galaxy S21 5G 128GB - Phantom Grey")]
  [InlineData(airpodsPath, "Apple AirPods (2021)")]
  public async Task GetTitle_PageExists_TitleIsRetrieved(string url, string expectedTitle)
  {
    var uut = CreateModel(url);
    var title = await uut.GetTitle();
    title.Should().Be(expectedTitle);
  }


  [Theory]
  [InlineData(galaxyS21Path, 4777)]
  [InlineData(airpodsPath, 1333)]
  public async Task GetTitle_PageExists_CurrentPriceIsRetrieved(string url, decimal expectedCurrentPrice)
  {
    var uut = CreateModel(url);
    var price = await uut.GetCurrentPrice();
    price.Should().Be(expectedCurrentPrice);
  }


  [Theory]
  [InlineData(galaxyS21Path, 6599)]
  [InlineData(airpodsPath, 1495)]
  public async Task GetTitle_PageExists_NormalPriceIsRetrieved(string url, decimal expectedNormalPrice)
  {
    var uut = CreateModel(url);
    var price = await uut.GetNormalPrice();
    price.Should().Be(expectedNormalPrice);
  }


  [Theory]
  [InlineData(galaxyS21Path)]
  [InlineData(airpodsPath)]
  public void GetTitle_PageExists_CurrencyIsDKK(string url)
  {
    var uut = CreateModel(url);
    uut.Currency.Should().Be(CurrencyIsoCode.DKK);
  }
}