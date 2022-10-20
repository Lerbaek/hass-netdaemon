using Microsoft.Extensions.Configuration;
using Serilog;

namespace Lerbaek.NetDaemon.Common.Logging;

public static class CustomLoggingProvider
{
  /// <summary>
  ///   Adds standard serilog logging configuration, from appsettings, as per:
  ///   https://github.com/datalust/dotnet6-serilog-example
  /// </summary>
  /// <param name="builder"></param>
  public static IHostBuilder UseCustomLogging(this IHostBuilder builder)
  {
    var configuration = new ConfigurationBuilder()
      .AddJsonFile("appsettings.json")
      .Build();

    var logger = new LoggerConfiguration()
      .ReadFrom.Configuration(configuration)
      .CreateLogger();

    return builder.UseSerilog(logger);
  }
}