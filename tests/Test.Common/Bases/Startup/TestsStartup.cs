using Microsoft.Extensions.DependencyInjection;

namespace Lerbaek.Test.Common.Bases.Startup
{
  public abstract class TestsStartup
  {
    public abstract void ConfigureServices(IServiceCollection services);
  }
}