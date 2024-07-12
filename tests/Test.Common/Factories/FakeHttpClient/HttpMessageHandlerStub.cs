using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Lerbaek.Test.Common.Factories.FakeHttpClient
{
  public class HttpMessageHandlerStub : DelegatingHandler
  {
    private Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> HandlerFunc { get; }

    public HttpMessageHandlerStub() => HandlerFunc = (_, __) => Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));

    public HttpMessageHandlerStub(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> handlerFunc) =>
      HandlerFunc = handlerFunc;

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
      HandlerFunc(request, cancellationToken);
  }
}