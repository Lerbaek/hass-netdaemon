using System.Diagnostics.CodeAnalysis;
using Lerbaek.HostBuilder;
using Lerbaek.Test.Common.Bases.TestClass;
using Microsoft.Extensions.DependencyInjection;

namespace Lerbaek.Test.Common.Bases.Startup
{
  [SuppressMessage("ReSharper", "UnusedMember.Global")]
  public abstract class HttpClientModelTestsStartup/* : LoggerTestsStartup*/
  {
    public /*override*/ void ConfigureServices(IServiceCollection services)
    {
      //base.ConfigureServices(services);
      services
        .AddHttpClient(nameof(HttpClientModelTestsBase))
        .AddLerbaekRetryPolicyHandler<HttpClientModelTestsBase>();
    }
  }
}