using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Polly;
using Polly.Contrib.WaitAndRetry;
using static System.Net.HttpStatusCode;
using static Polly.Extensions.Http.HttpPolicyExtensions;

namespace Lerbaek.HostBuilder
{
  public static class HostBuilderExtensions
  {
    public static IHttpClientBuilder AddLerbaekRetryPolicyHandler<T>(this IHttpClientBuilder builder) =>
      builder.AddPolicyHandler(RetryPolicy<T>);

    private static IAsyncPolicy<HttpResponseMessage> RetryPolicy<TType>(IServiceProvider serviceProvider, HttpRequestMessage _) =>
      HandleTransientHttpError()
        .OrResult(msg => msg.StatusCode == NotFound)
        .OrResult(msg => msg.StatusCode == Conflict)
        .WaitAndRetryAsync(Backoff.ExponentialBackoff(TimeSpan.FromMilliseconds(100), 20, 1.1), (result, __, retryCount, ___) =>
        {
          var logger = serviceProvider.GetRequiredService<ILogger<TType>>();
          logger.LogTrace("Request failed.");
          logger.LogTrace("Retry count: {RetryCount}.", retryCount);
          if (!(result.Result?.StatusCode is null))
            logger.LogTrace("Status code: {StatusCode} ({StatusCodeName})", (int)result.Result.StatusCode, result.Result.StatusCode);
          var exception = result.Exception;
          if(exception is null)
            return;
          logger.LogTrace("{StackTrace}", exception.ToString());
        });
  }
}