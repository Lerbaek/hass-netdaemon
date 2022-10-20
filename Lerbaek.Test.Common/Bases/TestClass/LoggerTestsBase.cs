using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Lerbaek.Test.Common.Bases.TestClass
{
  public abstract class LoggerTestsBase
  {
    protected ILogger Logger { get; }

    protected LoggerTestsBase(ITestOutputHelper output)
    {
      var services = new ServiceCollection().AddLogging(loggingBuilder => loggingBuilder.AddXUnit(output).SetMinimumLevel(LogLevel.Debug));
      Logger = services.BuildServiceProvider().GetRequiredService<ILogger<LoggerTestsBase>>();
    }
  }
}