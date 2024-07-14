using Xunit.Abstractions;

namespace Lerbaek.Test.Common.Bases.TestClass
{
  public abstract class HttpClientModelTestsBase : LoggerTestsBase
  {
    protected HttpClient HttpClient { get; }
  
    protected HttpClientModelTestsBase(IHttpClientFactory httpClientFactory, ITestOutputHelper output) : base(output)
    {
      HttpClient = httpClientFactory.CreateClient(nameof(HttpClientModelTestsBase));
    }
  }
}