using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FluentResults;
using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.Serialization;
using Microsoft.Extensions.Logging;

namespace Lerbaek.Calendar.Lectio
{
  public abstract class CalendarModel
  {
    protected ILogger Logger { get; }

    protected CalendarModel(ILogger logger) => Logger = logger;

    public abstract Task<Result<IEnumerable<IEventModel>>> GetEvents();

    public async Task<Result<Ical.Net.Calendar>> CreateCalendar(string name, string description = null)
    {
      Logger.LogInformation("Creating calendar \"{Name}\"", name);

      var scheduleResult = await GetEvents();
      if (scheduleResult.IsFailed)
        return Result.Fail(scheduleResult.Errors);
      var calendar = new Ical.Net.Calendar
      {
        Method = "PUBLISH",
        Scale = "GREGORIAN",
        ProductId = $"homeassistant.lerbaek.dk/{GetType().Name}/",
        Properties =
        {
          new CalendarProperty("REFRESH-INTERVAL;VALUE=DURATION", "PT1H"),
          new CalendarProperty("X-PUBLISHED-TTL", "PT1H"),
          new CalendarProperty("X-WR-CALDESC", description ?? name),
          new CalendarProperty("X-WR-CALNAME", name),
          new CalendarProperty("X-WR-TIMEZONE", "Europe/Copenhagen"),
          new CalendarProperty("TZNAME", "CEST")
        }
      };
      var fromDateTimeZone = VTimeZone.FromDateTimeZone("Europe/Copenhagen");
      calendar.AddTimeZone(fromDateTimeZone);
      calendar.Events.AddRange(scheduleResult.Value.Select(@class => @class.CalendarEvent));

      Logger.LogInformation("Calendar created.");

      return calendar;
    }

    public async Task<Result<Ical.Net.Calendar>> SaveCalendar(string path, string name, string description = null)
    {
      var calendarResult = await CreateCalendar(name, description);
      if (calendarResult.IsFailed)
        return Result.Fail(calendarResult.Errors);
      var calendar = calendarResult.Value;

      var serializer = new CalendarSerializer();
      var serializedCalendar = serializer.SerializeToString(calendar);
      File.WriteAllText(path, serializedCalendar);
      Logger.LogInformation("Calendar saved to {Path}", path);

      return calendar;
    }
  }
}