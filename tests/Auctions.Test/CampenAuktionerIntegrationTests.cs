using FluentAssertions;
using Lerbaek.Auctions.CampenAuktioner;
using Lerbaek.Test.Common.Bases.TestClass;
using Xunit;
using Xunit.Abstractions;

namespace Lerbaek.Auctions.Test;

[Collection(nameof(CampenAuktionerSite))]
public class CampenAuktionerIntegrationTests : HttpClientModelTestsBase
{
  private readonly CampenAuktionerSite uut;

  public CampenAuktionerIntegrationTests(
    IHttpClientFactory httpClientFactory, ITestOutputHelper output)
    : base(httpClientFactory, output) =>
    uut = new CampenAuktionerSite(Logger, HttpClient);

  [Fact]
  public async Task GetMatches_GetAllItems_ItemsFound()
  {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
    var matches = await uut.GetMatchesAsync();
    matches.Should().NotBeNullOrEmpty();
  }
}