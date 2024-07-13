using System.Net;

namespace Lerbaek.Auctions.Test;

public class HttpMessageHandlerStub(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> handlerFunc)
  : DelegatingHandler
{
  private Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> HandlerFunc { get; } = handlerFunc;

  public HttpMessageHandlerStub() : this((_, _) => Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)))
  {
  }

  protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
    HandlerFunc(request, cancellationToken);
}