﻿using System.Text.Json.Nodes;
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
    IlvaModel.TryCreate(GetALink().Result, HttpClient, Logger, out uut)
      .Should().BeTrue();
    
  }

  public async Task<Uri> GetALink()
  {
    var popularProductResponse =
      await HttpClient.GetAsync(
        "https://api.ilva.dk/api/recommendations/getPopularProductCategoriesRecommendations/?displayedAtLocationType=Front+Page&numOfRecommendations=1");


    var baseUrl = new Uri("http://ilva.dk/");
    var popularProductStream = await popularProductResponse.Content.ReadAsStreamAsync();
    var popularProductJson = await JsonNode.ParseAsync(popularProductStream);
    var dataJson = popularProductJson?["data"]?[0];
    var variantsJson = dataJson?["variants"]?[0];
    var relativePath = variantsJson?["url"]?.GetValue<string>();
    relativePath.Should().NotBeNull();
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