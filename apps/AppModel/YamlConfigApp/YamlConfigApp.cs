namespace AppModel;
/// <summary>
///     Showcases how to instance apps with yaml and use automatic configuration population
///     For advanced configuration options see 
///     https://netdaemon.xyz/docs/app_model/app_model_advanced_config
/// </summary>
[NetDaemonApp]
public class HelloYamlApp : IInitializable
{
    // This will be populated from the yaml with same name
    public string? HelloMessage { get; set; }

    private readonly IHaContext _ha;
    public HelloYamlApp(IHaContext ha) => _ha = ha;

    public void Initialize()
    {
        // The properties is not populated in constructor so it needs to be in the
        // Initialize function.
        _ha.CallService("notify", "persistent_notification", data: new { message = HelloMessage, title = "Hello yaml app!" });
    }
}