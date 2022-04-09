using FluentAssertions;
using Lerbaek.Auctions.CampenAuktioner;
using Lerbaek.HostBuilder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Lerbaek.Auctions.Test
{
  [Collection(nameof(CampenAuktionerSite))]
  public class CampenAuktionerIntegrationTests : AuctionsTestBase
  {
    private readonly CampenAuktionerSite uut;

    public CampenAuktionerIntegrationTests()
    {
      Services.AddHttpClient<CampenAuktionerIntegrationTests>(nameof(CampenAuktionerIntegrationTests))
        .AddLerbaekRetryPolicyHandler<CampenAuktionerIntegrationTests>();

      var serviceProvider = BuildServiceProvider();
      var logger = serviceProvider.GetRequiredService<ILoggerFactory>().CreateLogger<CampenAuktionerIntegrationTests>();
      var httpClient = serviceProvider.GetRequiredService<IHttpClientFactory>().CreateClient(nameof(CampenAuktionerIntegrationTests));
      uut = new CampenAuktionerSite(logger, httpClient);
    }

    [Fact]
    public async Task GetMatches_GetAllItems_ItemsFound() => (await uut.GetMatchesAsync()).Should().NotBeNullOrEmpty();
  }
}