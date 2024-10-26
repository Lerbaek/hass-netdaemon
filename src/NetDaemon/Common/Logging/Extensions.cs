using System.Diagnostics;

namespace Lerbaek.NetDaemon.Common.Logging;

internal static class Extensions
{
    // Todo: Use [CallerMemberName] instead
    internal static void LogErrorMethod(this ILogger logger, Exception e) =>
      ((Action<MethodBase>)(mb => logger.LogError(e, "An error occurred in {Method}", mb.Name))).DoWithStackParent();

    internal static void DoWithStackParent(this Action<MethodBase> action)
    {
        var stackTrace = new StackTrace();
        foreach (var methodBase in stackTrace.GetFrames().Skip(2).Select(sf => sf.GetMethod()))
        {
            var fullName = methodBase!.DeclaringType!.FullName!;
            if (!fullName.StartsWith(nameof(Lerbaek)) || fullName.Contains('+'))
                continue;

            action(methodBase);
            return;
        }
    }

    internal static IDisposable? BeginScopeWithCorrelationId(this ILogger logger, params (string Field, object? Value)[] context)
    {
        context = [
            .. context,
            ("CorrelationId", Guid.NewGuid())];

        return logger.BeginScope(
            context.ToDictionary(
                c => c.Field,
                c => c.Value));
    }
}