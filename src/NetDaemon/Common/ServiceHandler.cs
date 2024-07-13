namespace Lerbaek.NetDaemon.Common;

public class ServiceHandler(IHaContext haContext, string prefix)
{
  protected readonly IHaContext HaContext = haContext;
  private readonly NameGenerator nameGenerator = new(prefix);

  public void RegisterService<T>(string serviceName, Func<T, Task> service)
  {
    HaContext.RegisterServiceCallBack<T>(nameGenerator.Service(serviceName),
      attributes => service(attributes));
  }

  public void RegisterService(string serviceName, Func<Task> service)
  {
    HaContext.RegisterServiceCallBack<Empty>(nameGenerator.Service(serviceName), _ => service());
  }

  private record Empty;

  public static void LogServiceCall(ILogger logger, string serviceName, params object[] args) =>
    logger.LogTrace("{Method}({Args}) has been called", serviceName, string.Join(", ", args));
}