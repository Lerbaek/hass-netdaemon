using FluentAssertions;
using Lerbaek.Auctions.CampenAuktioner;
using Lerbaek.Test.Common.Bases.TestClass;
using Xunit;
using Xunit.Abstractions;

namespace Lerbaek.Auctions.Test;

[Collection(nameof(CampenAuktionerSite))]
public class CampenAuktionerIntegrationTests : HttpClientModelTestsBase
{
  private readonly CampenAuktionerSite _uut;

  public CampenAuktionerIntegrationTests(
    IHttpClientFactory httpClientFactory, ITestOutputHelper output)
    : base(httpClientFactory, output) =>
    _uut = new CampenAuktionerSite(Logger, HttpClient);

  [Fact]
  public async Task GetMatches_GetAllItems_ItemsFound()
  {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
    var matches = await _uut.GetMatchesAsync();
    matches.Should().NotBeNullOrEmpty();
  }
}