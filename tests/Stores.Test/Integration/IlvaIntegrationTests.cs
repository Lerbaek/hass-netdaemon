using FluentAssertions;
using HtmlAgilityPack;
using Lerbaek.Test.Common.Bases.TestClass;
using Xunit;
using Xunit.Abstractions;

namespace Lerbaek.Stores.Test.Integration;

[Collection(nameof(IlvaModel))]
public class IlvaIntegrationTests : HttpClientModelTestsBase
{
  private readonly IlvaModel uut;

  public IlvaIntegrationTests(
    IHttpClientFactory httpClientFactory, ITestOutputHelper output)
    : base(httpClientFactory, output)
  {
    IlvaModel.TryCreate(GetALink(), HttpClient, Logger, out uut)
      .Should().BeTrue();
    
  }

  public static Uri GetALink()
  {
    var baseUrl = new Uri("http://ilva.dk/");
    var web = new HtmlWeb();
    var doc = web.Load(baseUrl);
    var spotLinkNodes = doc.DocumentNode.SelectNodes("//a [@class='ribbon-tile__link']");
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