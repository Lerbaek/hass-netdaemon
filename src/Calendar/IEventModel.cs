using System;
using Ical.Net.CalendarComponents;

namespace Lerbaek.Calendar
{
  public interface IEventModel
  {
    string Name { get; }
    DateTime StartTime { get; }
    TimeSpan Duration { get; }
    string Description { get; }
    CalendarEvent CalendarEvent { get; }
  }
}