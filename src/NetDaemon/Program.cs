using FluentValidation;
using Lerbaek.HostBuilder;
using Lerbaek.NetDaemon.Apps.Integrations.CampenAuktioner;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Configuration;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;
using Lerbaek.NetDaemon.Archive.Apps.Monitoring.Lectio;
using Lerbaek.NetDaemon.Common.Logging;
using Lerbaek.NetDaemon.Common.Validation;
using Microsoft.Extensions.Options;
using NetDaemon.Extensions.MqttEntityManager;

#pragma warning disable CA1812

try
{
  await Host.CreateDefaultBuilder(args)
    .UseNetDaemonAppSettings()
    .ValidateConfig()
    .UseNetDaemonRuntime()
    .UseNetDaemonTextToSpeech()
    .UseNetDaemonMqttEntityManagement()
    .ConfigureServices(ServiceConfiguration)
    .UseCustomLogging()
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

static void ServiceConfiguration(IServiceCollection services)
{
  services.AddAppsFromAssembly(Assembly.GetExecutingAssembly())
    .AddNetDaemonStateManager()
    .AddNetDaemonScheduler()
    .AddHomeAssistantGenerated();

  services
    .AddHttpClient<Nordlux>(nameof(Nordlux))
    .AddLerbaekRetryPolicyHandler<Nordlux>();

  services.AddSingleton<IValidateOptions<NordluxConfig>, NordluxConfigValidator>();

  services
    .AddHttpClient<CampenAuktioner>(nameof(CampenAuktioner))
    .AddLerbaekRetryPolicyHandler<CampenAuktioner>();

  services
    .AddHttpClient<LectioCalendar>(nameof(LectioCalendar))
    .AddLerbaekRetryPolicyHandler<LectioCalendar>();

  services.AddSingleton<IFileSystem, FileSystem>();
  services.AddSingleton<IValidator<VoiceNotificationBuilder>, NotificationBuilderValidator>();
  services.AddTransient<INotificationBuilder, NotificationBuilder>();
  services.AddTransient<IRequestHandler, RequestHandler>();
}