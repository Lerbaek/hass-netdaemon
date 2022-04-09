using FluentValidation;
using Lerbaek.HostBuilder;
using Lerbaek.NetDaemon.Apps.Integrations.CampenAuktioner;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux;
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

static void ServiceConfiguration(HostBuilderContext _, IServiceCollection services)
{
  services.AddAppsFromAssembly(Assembly.GetExecutingAssembly())
    .AddNetDaemonStateManager()
    .AddNetDaemonScheduler();

  services
    .AddHttpClient<Nordlux>(nameof(Nordlux))
    .AddLerbaekRetryPolicyHandler<Nordlux>();

  services
    .AddHttpClient<CampenAuktioner>(nameof(CampenAuktioner))
    .AddLerbaekRetryPolicyHandler<CampenAuktioner>();

  services.AddSingleton<IFileSystem, FileSystem>();
  services.AddSingleton<IValidator<VoiceNotificationBuilder>, NotificationBuilderValidator>();
  services.AddTransient<INotificationBuilder, NotificationBuilder>();
  services.AddTransient<IRequestHandler, RequestHandler>();
}