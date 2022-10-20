using System.Net;
using FluentAssertions;
using Lerbaek.Auctions.CampenAuktioner;
using Lerbaek.Test.Common;
using Lerbaek.Test.Common.Bases.TestClass;
using Lerbaek.Test.Common.Factories.FakeHttpClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RegExtract;
using Xunit;
using Xunit.Abstractions;

namespace Lerbaek.Auctions.Test;

public class CampenAuktionerTests : LoggerTestsBase
{
  private readonly CampenAuktionerSite uut;
  private readonly IEnumerable<CampenAuktionerItem> itemsWithA;

  public CampenAuktionerTests(ITestOutputHelper output) : base(output)
  {
    var httpClient = FakeHttpClientFactory.Create((request, _) =>
    {
      var page = request.RequestUri!.AbsoluteUri.Extract<int>(@"pn=(\d+)&");
      var stream = GetType().Assembly.GetManifestResourceStream("Lerbaek.Auctions.Test.SampleData.page" + page + ".json")!;
      var response = new HttpResponseMessage(HttpStatusCode.OK)
      {
        Content = new StreamContent(stream)
      };
      return Task.FromResult(response);
    });
      
    uut = new CampenAuktionerSite(Logger, httpClient);
    itemsWithA = uut.GetMatchesAsync(new[] { "a" }).Result;
  }

  [Fact]
  public void GetMatches_SearchTermA_ItemsFound() => itemsWithA.Should().NotBeNullOrEmpty();

  [Fact]
  public async Task GetMatches_SearchTermANotX_FewerItemsFound()
  {
    var itemsSubset = await uut.GetMatchesAsync(new[] { "a -x" });
    itemsSubset.Count().Should().BeLessThan(itemsWithA.Count());
  }
}