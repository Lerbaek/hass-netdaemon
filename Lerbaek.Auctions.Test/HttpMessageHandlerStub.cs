using System.Net;

namespace Lerbaek.Auctions.Test;

public class HttpMessageHandlerStub : DelegatingHandler
{
  private Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> HandlerFunc { get; }

  public HttpMessageHandlerStub() => HandlerFunc = (_, _) => Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));

  public HttpMessageHandlerStub(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> handlerFunc) =>
    HandlerFunc = handlerFunc;

  protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
    HandlerFunc(request, cancellationToken);
}