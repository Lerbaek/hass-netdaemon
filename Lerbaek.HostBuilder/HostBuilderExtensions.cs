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
    public static IHttpClientBuilder AddLerbaekRetryPolicyHandler<T>(this IHttpClientBuilder builder)
    {
      return builder.AddPolicyHandler(RetryPolicy<T>);
    }

    private static IAsyncPolicy<HttpResponseMessage> RetryPolicy<TType>(IServiceProvider serviceProvider, HttpRequestMessage _) =>
      HandleTransientHttpError()
        .OrResult(msg => msg.StatusCode == NotFound)
        .OrResult(msg => msg.StatusCode == Conflict)
        .WaitAndRetryAsync(Backoff.ExponentialBackoff(TimeSpan.FromMilliseconds(100), 20, 1.1), (result, __, retryCount, ___) =>
        {
          var logger = serviceProvider.GetRequiredService<ILogger<TType>>();
          logger.LogWarning("Request failed.");
          logger.LogWarning("Retry count: {RetryCount}.", retryCount);
          if (!(result.Result?.StatusCode is null))
            logger.LogDebug("Status code: {StatusCode} ({StatusCodeName})", (int)result.Result.StatusCode, result.Result.StatusCode);
          var exception = result.Exception;
          if(exception is null)
            return;
          logger.LogDebug("Exception message: {Message}", exception.Message);
          logger.LogTrace("{StackTrace}", exception.ToString());
        });
  }
}