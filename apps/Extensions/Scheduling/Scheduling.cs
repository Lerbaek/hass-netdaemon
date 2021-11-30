using NetDaemon.Extensions.Scheduler;

// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace Extensions.Scheduling;
/// <summary>
///     Showcase the scheduling capabilities of NetDaemon
/// </summary>
[NetDaemonApp]
public class SchedulingApp
{
    public SchedulingApp(IHaContext ha, INetDaemonScheduler scheduler)
    {
        scheduler.RunEvery(TimeSpan.FromSeconds(5), () => ha.CallService("notify", "persistent_notification", data: new { message = "This is a sceduled action!", title = "Schedule!" }));
    }
}