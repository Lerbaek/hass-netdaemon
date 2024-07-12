using System.Net;
using FluentAssertions;
using Lerbaek.Test.Common.Bases.TestClass;
using Lerbaek.Test.Common.Factories.FakeHttpClient;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Lerbaek.Stores.Test.Component;

public class StoreTestBase : LoggerTestsBase
{
  protected HttpClient HttpClient;

  public StoreTestBase(ITestOutputHelper output, Func<Uri, ILogger, string> getProductId) : base(output)
  {
    HttpClient = FakeHttpClientFactory.Create((message, _) =>
    {
      var productId = getProductId(message.RequestUri!, Logger);
      var assembly = GetType().Assembly;
      var stream = assembly.GetManifestResourceStream($"Lerbaek.Stores.Test.SampleData.{productId}.html");
      var response = new HttpResponseMessage(HttpStatusCode.OK)
      {
        Content = new StreamContent(stream!)
      };
      return Task.FromResult(response);
    });
  }
  
  protected T CreateModel<T>(Uri url, TryCreateModel<T> tryCreateModel)
  {
    tryCreateModel(url, HttpClient, Logger, out var uut).Should().BeTrue();
    return uut;
  }

  protected delegate bool TryCreateModel<T>(Uri url, HttpClient httpClient, ILogger logger, out T uut);
}