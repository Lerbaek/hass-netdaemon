using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.CampenAuktioner;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux;
using Lerbaek.NetDaemon.Common;
using Lerbaek.NetDaemon.Common.Notifications;
using NetDaemon.Extensions.MqttEntityManager;

#pragma warning disable CA1812

try
{

  await Host.CreateDefaultBuilder(args)
        .UseNetDaemonAppSettings()
        .UseNetDaemonDefaultLogging()
        .UseNetDaemonRuntime()
        .UseNetDaemonTextToSpeech()
        .UseNetDaemonMqttEntityManagement()
        .ConfigureServices(ServiceConfiguration)
#if DEBUG
        .UseEnvironment("Development")
#endif
        .Build()
        .RunAsync()
        .ConfigureAwait(false);
}
catch (Exception e)
{
    Console.WriteLine($"Failed to start host... {e}");
    throw;
}

void ServiceConfiguration(HostBuilderContext _, IServiceCollection services)
{
  services.AddAppsFromAssembly(Assembly.GetExecutingAssembly())
    .AddNetDaemonStateManager()
    .AddNetDaemonScheduler();

  services
    .AddHttpClient<Nordlux>(nameof(Nordlux))
    .AddPolicyHandler(RetryPolicy<Nordlux>);

  services
    .AddHttpClient<CampenAuktioner>(nameof(CampenAuktioner))
    .AddPolicyHandler(RetryPolicy<CampenAuktioner>);

  services.AddSingleton<IFileSystem, FileSystem>();
  services.AddSingleton<IValidator<VoiceNotificationBuilder>, NotificationBuilderValidator>();
  services.AddTransient<INotificationBuilder, NotificationBuilder>();
  services.AddTransient<IRequestHandler, RequestHandler>();
}

IAsyncPolicy<HttpResponseMessage> RetryPolicy<TType>(IServiceProvider serviceProvider, HttpRequestMessage _) =>
  HandleTransientHttpError()
    .OrResult(msg => msg.StatusCode == NotFound)
    .WaitAndRetryAsync(Backoff.ExponentialBackoff(TimeSpan.FromMilliseconds(100), 6), (result, _, retryCount, _) =>
    {
      var logger = serviceProvider.GetRequiredService<ILogger<TType>>();
      logger.LogWarning("Request failed.");
      logger.LogWarning("Retry count: {RetryCount}.", retryCount);
      if (result.Result?.StatusCode is not null)
        logger.LogDebug("Status code: {StatusCode} ({StatusCodeName})", (int)result.Result.StatusCode, result.Result.StatusCode);
      var exception = result.Exception;
      logger.LogDebug("Exception message: {Message}", exception.Message);
      logger.LogTrace("{StackTrace}", exception.ToString());
    });