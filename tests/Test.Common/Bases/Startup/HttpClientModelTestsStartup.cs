using Lerbaek.HostBuilder;
using Lerbaek.Test.Common.Bases.TestClass;
using Microsoft.Extensions.DependencyInjection;

namespace Lerbaek.Test.Common.Bases.Startup
{
  public abstract class HttpClientModelTestsStartup : TestsStartup
  {
    public override void ConfigureServices(IServiceCollection services)
    {
      //base.ConfigureServices(services);
      services
        .AddHttpClient(nameof(HttpClientModelTestsBase))
        .AddLerbaekRetryPolicyHandler<HttpClientModelTestsBase>();
    }
  }
}