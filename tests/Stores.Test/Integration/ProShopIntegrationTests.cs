using System.Text.RegularExpressions;
using FluentAssertions;
using HtmlAgilityPack;
using Lerbaek.Test.Common.Bases.TestClass;
using Xunit;
using Xunit.Abstractions;

namespace Lerbaek.Stores.Test.Integration;

public class ProShopIntegrationTests : HttpClientModelTestsBase
{
  private readonly ProShopModel _uut;

  public ProShopIntegrationTests(
    IHttpClientFactory httpClientFactory, ITestOutputHelper output)
    : base(httpClientFactory, output)
  {
    ProShopModel.TryCreate(GetALink(), HttpClient, Logger, out _uut)
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
    const string endsWithProductIdRegex = @"\/\d+$";
    var relativePath = spotLinkNodes
      .Select(n => n.Attributes["href"].Value)
      .First(href => Regex.IsMatch(href, endsWithProductIdRegex));
    var link = new Uri(baseUrl, relativePath);
    return link;
  }

  [Fact(Skip = "Archived")]
  public async Task GetTitle_PageExists_TitleIsRetrieved()
  {
    var title = await _uut.GetTitle();
    title.Should().NotBeNullOrEmpty();
  }

  [Fact(Skip = "Archived")]
  public async Task GetTitle_PageExists_CurrentPriceIsRetrieved()
  {
    var price = await _uut.GetCurrentPrice();
    price.Should().BeGreaterThan(0);
  }

  [Fact(Skip = "Archived")]
  public async Task GetTitle_PageExists_NormalPriceIsRetrieved()
  {
    var price = await _uut.GetNormalPrice();
    price.Should().BeGreaterThan(0);
  }
}