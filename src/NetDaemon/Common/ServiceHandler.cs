using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Lerbaek.NetDaemon.Common;

public class ServiceHandler(IHaContext haContext, string prefix)
{
    protected readonly IHaContext HaContext = haContext;
    private readonly NameGenerator _nameGenerator = new(prefix);

    public void RegisterService<T>(string serviceName, Func<T, Task> service)
    {
        HaContext.RegisterServiceCallBack<T>(
            _nameGenerator.Service(serviceName),
            attributes => service(attributes));
    }

    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Local", Justification = "Needed to register services without data")]
    private record Empty;

    public void RegisterService(string serviceName, Func<Task> service)
    {
        HaContext.RegisterServiceCallBack<Empty>(_nameGenerator.Service(serviceName), _ => service());
    }

    public static void LogServiceCall(ILogger logger, [CallerMemberName] string serviceName = "") =>
      logger.LogTrace("{Method}() has been called", serviceName);
}