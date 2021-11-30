// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace AppModel;
/// <summary>
///     Showcase using application context information and logging
/// </summary>
[NetDaemonApp]
public class HelloAppContext
{
    public HelloAppContext(IApplicationContext appCtx, ILogger<HelloAppContext> logger)
    {
        logger.LogInformation("Hello from app with unique identity='{id}'", appCtx.Id);
    }
}