﻿using System.Net;
using System.Web;
using FluentAssertions;
using Lerbaek.Test.Common.Factories.FakeHttpClient;
using Microsoft.Extensions.Logging;
using NMoneys;
using Xunit;
using Xunit.Abstractions;

namespace Lerbaek.Stores.Test.Component;

public class IlvaTests : StoreTestBase
{
  private const string WoodstockPath = "/stuen/sofaborde/woodstock/top-i-olieret-egefiner/p-1055729-5642100692/";
  private const string BestlaPath    = "/havemoebler/liggestole/bestla/graa-polyester-reb/p-1068901-5642651197/";

  public IlvaTests(ITestOutputHelper output) : base(output, GetProductId)
  {
    HttpClient = FakeHttpClientFactory.Create((message, _) =>
    {
      var url = message.RequestUri!;
      var productId = GetProductId(url, Logger);
      var assembly = GetType().Assembly;
      var stream = assembly.GetManifestResourceStream($"Lerbaek.Stores.Test.SampleData.{productId}.json");
      var response = new HttpResponseMessage(HttpStatusCode.OK)
      {
        Content = new StreamContent(stream!)
      };
      return Task.FromResult(response);
    });
  }

  private static string GetProductId(Uri url, ILogger logger)
  {
      var query = HttpUtility.ParseQueryString(url.Query);
      var productId = query["productIds"];
      return productId!;
  }

  private IlvaModel CreateModel(string url) =>
    CreateModel<IlvaModel>(new Uri($"https://proshop.dk{url}"), IlvaModel.TryCreate);

  [Theory(Skip = "Archived")]
  [InlineData(WoodstockPath, "Woodstock Sofabord 120 x 47 x 60 cm")]
  [InlineData(BestlaPath, "Bestla Solseng")]
  public async Task GetTitle_PageExists_TitleIsRetrieved(string url, string expectedTitle)
  {
    var uut = CreateModel(url);
    var title = await uut.GetTitle();
    title.Should().Be(expectedTitle);
  }


  [Theory(Skip = "Archived")]
  [InlineData(WoodstockPath, 1799)]
  [InlineData(BestlaPath, 6999)]
  public async Task GetTitle_PageExists_CurrentPriceIsRetrieved(string url, decimal expectedCurrentPrice)
  {
    var uut = CreateModel(url);
    var price = await uut.GetCurrentPrice();
    price.Should().Be(expectedCurrentPrice);
  }


  [Theory(Skip = "Archived")]
  [InlineData(WoodstockPath, 2299)]
  [InlineData(BestlaPath, 8999)]
  public async Task GetTitle_PageExists_NormalPriceIsRetrieved(string url, decimal expectedNormalPrice)
  {
    var uut = CreateModel(url);
    var price = await uut.GetNormalPrice();
    price.Should().Be(expectedNormalPrice);
  }


  [Theory(Skip = "Archived")]
  [InlineData(WoodstockPath)]
  [InlineData(BestlaPath)]
  public void GetTitle_PageExists_CurrencyIsDKK(string url)
  {
    var uut = CreateModel(url);
    uut.Currency.Should().Be(CurrencyIsoCode.DKK);
  }
}