using System;
using System.Globalization;
using System.Linq;
using HtmlAgilityPack;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using RegExtract;
using static System.Environment;

namespace Lerbaek.Calendar.Lectio
{
  public class LectioClassModel : IEventModel
  {
    public string Name { get; }
    public DateTime StartTime { get; }
    public TimeSpan Duration { get; }
    public string Description { get; }

    public CalendarEvent CalendarEvent =>
      new CalendarEvent
      {
        Summary = $"{(Cancelled ? "[Aflyst] " : string.Empty)}{Name}",
        Start = new CalDateTime(StartTime),
        End = new CalDateTime(StartTime + Duration),
        Description = $"{Description}{NewLine}{NewLine}{Link.AbsolutePath}",
        
      };

    public Uri Link { get; }
    public bool Cancelled { get; }

    public LectioClassModel(string course, DateTime startTime, TimeSpan duration, string description, Uri link, bool cancelled = false)
    {
      Name = course;
      StartTime = startTime;
      Duration = duration;
      Description = description;
      Link = link;
      Cancelled = cancelled;
    }

    public static LectioClassModel Parse(HtmlNode htmlNode)
    {
      var activityNode = htmlNode.SelectSingleNode(".//a");
      var additionalInfo = activityNode.GetAttributeValue("data-additionalinfo", null);
      var course = additionalInfo.Extract<string>("(?<=Hold: ).*");
      var startDateTimeString = additionalInfo.Extract<string>(".*-\\d{4}.*(?= til )");
      var startDateTime = DateTime.Parse(startDateTimeString, CultureInfo.GetCultureInfo("da-DK"));
      var endTime = additionalInfo.Extract<TimeSpan>("(?<= til ).*");
      var link = activityNode.GetAttributeValue("href", null);
      var baseUriNode = htmlNode.OwnerDocument.DocumentNode.SelectSingleNode("//a[@class=\"ls-master-header-logo\"]");
      var baseUri = new Uri(baseUriNode.GetAttributeValue("href", null));
      var uri = new Uri(baseUri, link.Split('&').First());
      var cancelled = activityNode.HasClass("s2cancelled");

      return new LectioClassModel(course, startDateTime, endTime - startDateTime.TimeOfDay, additionalInfo,
        uri, cancelled);
    }
  }
}