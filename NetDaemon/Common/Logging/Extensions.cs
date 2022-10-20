using System.Reflection;

namespace Lerbaek.NetDaemon.Common.Logging;

internal static class Extensions
{
  internal static void LogErrorMethod(this ILogger logger, Exception e) =>
    ((Action<MethodBase>)(mb => logger.LogError(e, "An error occurred in {method}", mb.Name))).DoWithStackParent();

  internal static void DoWithStackParent(this Action<MethodBase> action)
  {
    var stackTrace = new System.Diagnostics.StackTrace();
    foreach (var methodBase in stackTrace.GetFrames().Skip(2).Select(sf => sf.GetMethod()))
    {
      var fullName = methodBase!.DeclaringType!.FullName!;
      if (!fullName.StartsWith(nameof(Lerbaek)) || fullName.Contains('+'))
        continue;

      action(methodBase);
      return;
    }
  }
}