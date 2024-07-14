using Xunit.Abstractions;

namespace Lerbaek.Test.Common.Bases.TestClass
{
  public abstract class HttpClientModelTestsBase(IHttpClientFactory httpClientFactory, ITestOutputHelper output) : LoggerTestsBase(output)
  {
    protected HttpClient HttpClient { get; } = httpClientFactory.CreateClient(nameof(HttpClientModelTestsBase));
  }
}