using System.Net;
using System.Reflection;
using FluentAssertions;
using Lerbaek.Auctions.CampenAuktioner;
using Lerbaek.HostBuilder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RegExtract;
using Xunit;

namespace Lerbaek.Auctions.Test
{
  [Collection(nameof(CampenAuktionerSite))]
  public class CampenAuktionerTests : AuctionsTestBase
  {
    private readonly CampenAuktionerSite uut;
    private readonly IEnumerable<CampenAuktionerItem> itemsWithA;

    public CampenAuktionerTests()
    {
      var serviceProvider = BuildServiceProvider();
      
      var logger = serviceProvider.GetRequiredService<ILoggerFactory>().CreateLogger<CampenAuktionerTests>();

      var httpClient = MockHttpClient((request, _) =>
      {
        var page = request.RequestUri!.AbsoluteUri.Extract<int>(@"pn=(\d+)&");
        var stream = GetType().Assembly.GetManifestResourceStream("Lerbaek.Auctions.Test.SampleData.page" + page + ".json")!;
        var response = new HttpResponseMessage(HttpStatusCode.OK)
        {
          Content = new StreamContent(stream)
        };
        return Task.FromResult(response);
      });
      
      uut = new CampenAuktionerSite(logger, httpClient);
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
}