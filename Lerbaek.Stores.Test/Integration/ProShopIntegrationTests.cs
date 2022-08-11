using FluentAssertions;
using HtmlAgilityPack;
using Lerbaek.Test.Common.Bases.TestClass;
using Xunit;
using Xunit.Abstractions;

namespace Lerbaek.Stores.Test.Integration;

public class ProShopIntegrationTests : HttpClientModelTestsBase
{
  private readonly ProShopModel uut;

  public ProShopIntegrationTests(
    IHttpClientFactory httpClientFactory, ITestOutputHelper output)
    : base(httpClientFactory, output)
  {
    ProShopModel.TryCreate(GetALink(), HttpClient, Logger, out uut)
      .Should().BeTrue();
    
  }

  public static Uri GetALink()
  {
    var baseUrl = new Uri("https://www.proshop.dk");
    var campaignsUrl =
      new Uri(baseUrl, "Campaigns/Campaigns/CampaignAsync?campaignElementId=00000000-0000-0000-0000-000000000001");
    var web = new HtmlWeb();
    var doc = web.Load(campaignsUrl.AbsoluteUri);
    var spotLinkNodes = doc.DocumentNode.SelectNodes("//a");
    spotLinkNodes.Should().NotBeNull();
    var relativePath = spotLinkNodes.First().Attributes["href"].Value;
    var link = new Uri(baseUrl, relativePath);
    return link;
  }

  [Fact]
  public async Task GetTitle_PageExists_TitleIsRetrieved()
  {
    var title = await uut.GetTitle();
    title.Should().NotBeNullOrEmpty();
  }

  [Fact]
  public async Task GetTitle_PageExists_CurrentPriceIsRetrieved()
  {
    var price = await uut.GetCurrentPrice();
    price.Should().BeGreaterThan(0);
  }

  [Fact]
  public async Task GetTitle_PageExists_NormalPriceIsRetrieved()
  {
    var price = await uut.GetNormalPrice();
    price.Should().BeGreaterThan(0);
  }
}