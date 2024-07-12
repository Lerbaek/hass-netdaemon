using FluentValidation;
using Lerbaek.NetDaemon.Common.Notifications;
using Lerbaek.Test.Common.Bases.Startup;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.HassModel;
using NSubstitute;

namespace NetDaemon.Test;

public class Startup : TestsStartup
{
  public override void ConfigureServices(IServiceCollection services)
  {
    var haContext = Substitute.For<IHaContext>();

    services.AddSingleton(haContext);
    services.AddTransient<INotificationBuilder, NotificationBuilder>();
    services.AddTransient<IValidator<VoiceNotificationBuilder>, NotificationBuilderValidator>();
  }
}