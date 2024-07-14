namespace Lerbaek.Test.Common.Factories.FakeHttpClient
{
  public static class FakeHttpClientFactory
  {
    public static HttpClient Create(
      Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> mockHttpResponse)
    {
      var clientHandlerStub = new HttpMessageHandlerStub(mockHttpResponse);
      return new HttpClient(clientHandlerStub);
    }
  }
}