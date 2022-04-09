using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Lerbaek.Auctions.Test;

public class AuctionsTestBase
{
  protected IServiceCollection Services { get; }
  protected IServiceProvider BuildServiceProvider() => Services.BuildServiceProvider();

  public AuctionsTestBase()
  {
    Services = new ServiceCollection()
      .AddLogging(loggingBuilder => loggingBuilder.AddDebug());
  }

  protected static HttpClient MockHttpClient(
    Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> mockHttpResponse)
  {
    var clientHandlerStub = new HttpMessageHandlerStub(mockHttpResponse);
    return new HttpClient(clientHandlerStub);
  }
}