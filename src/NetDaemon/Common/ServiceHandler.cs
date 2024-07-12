namespace Lerbaek.NetDaemon.Common;

public class ServiceHandler
{
  protected readonly IHaContext HaContext;
  private readonly NameGenerator nameGenerator;

  public ServiceHandler(IHaContext haContext, string prefix)
  {
    this.HaContext = haContext;
    nameGenerator = new NameGenerator(prefix);
  }

  public void RegisterService<T>(string serviceName, Func<T, Task> service)
  {
    HaContext.RegisterServiceCallBack<T>(nameGenerator.Service(serviceName),
      attributes => service(attributes));
  }

  public void RegisterService<T>(string serviceName, Func<Task> service)
  {
    HaContext.RegisterServiceCallBack<T>(nameGenerator.Service(serviceName), _ => service());
  }

  public static void LogServiceCall(ILogger logger, string serviceName, params object[] args) =>
    logger.LogTrace("{Method}({Args}) has been called", serviceName, string.Join(", ", args));
}