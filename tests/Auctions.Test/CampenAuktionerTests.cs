using System.Net;
using AwesomeAssertions;
using Lerbaek.Auctions.CampenAuktioner;
using Lerbaek.Test.Common.Bases.TestClass;
using Lerbaek.Test.Common.Factories.FakeHttpClient;
using RegExtract;
using Xunit;

namespace Lerbaek.Auctions.Test;

public class CampenAuktionerTests : LoggerTestsBase
{
  private readonly CampenAuktionerSite _uut;
  private readonly IEnumerable<CampenAuktionerItem> _itemsWithA;

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
      
    _uut = new CampenAuktionerSite(Logger, httpClient);
    _itemsWithA = _uut.GetMatchesAsync(["a"]).Result;
  }

  [Fact(Skip = "Archived")]
  public void GetMatches_SearchTermA_ItemsFound() => _itemsWithA.Should().NotBeNullOrEmpty();

  [Fact(Skip = "Archived")]
  public async Task GetMatches_SearchTermANotX_FewerItemsFound()
  {
    var itemsSubset = await _uut.GetMatchesAsync(["a -x"]);
    itemsSubset.Count().Should().BeLessThan(_itemsWithA.Count());
  }
}