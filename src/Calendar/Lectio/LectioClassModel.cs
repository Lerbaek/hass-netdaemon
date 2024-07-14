using System;
using System.Globalization;
using System.Linq;
using FluentResults;
using HtmlAgilityPack;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Lerbaek.Lectio;
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

    public static Result<LectioClassModel> Parse(HtmlNode htmlNode)
    {
      var activityNode = htmlNode.SelectSingleNode(".//a");
      const string tooltipAttribute = "data-tooltip";
      var additionalInfo = activityNode.GetAttributeValue(tooltipAttribute, null);
      if (additionalInfo is null)
      {
        LectioError.AttributeNotFound.Metadata["attribute"] = tooltipAttribute;
        return Result.Fail(LectioError.AttributeNotFound);
      }

      var course = additionalInfo.Extract<string>("(?<=Hold: ).*");
      var startDateTimeString = additionalInfo.Extract<string>(".*-\\d{4}.*(?= til )");
      var startDateTime = ParseDateTime(startDateTimeString);
      var endTimeString = additionalInfo.Extract<string>("(?<=.*-\\d{4} \\d\\d:\\d\\d til ).*");
      var endTime = TimeSpan.TryParse(endTimeString, out var endTimeSpan)
        ? endTimeSpan
        : ParseDateTime(startDateTimeString).TimeOfDay;
      const string linkAttribute = "href";
      var link = activityNode.GetAttributeValue(linkAttribute, null);
      if (link is null)
      {
        LectioError.AttributeNotFound.Metadata["attribute"] = linkAttribute;
        return Result.Fail(LectioError.AttributeNotFound);
      }

      var baseUriNode = htmlNode.OwnerDocument.DocumentNode.SelectSingleNode("//a[@class=\"ls-master-header-logo\"]");
      var baseUriLink = baseUriNode.GetAttributeValue(linkAttribute, null);

      if (baseUriLink is null)
      {
        LectioError.AttributeNotFound.Metadata["attribute"] = linkAttribute;
        return Result.Fail(LectioError.AttributeNotFound);
      }

      var baseUri = new Uri(baseUriLink);
      var uri = new Uri(baseUri, link.Split('&').First());
      var cancelled = activityNode.HasClass("s2cancelled");

      return new LectioClassModel(course, startDateTime, endTime - startDateTime.TimeOfDay, additionalInfo,
        uri, cancelled);
    }

    private static DateTime ParseDateTime(string startDateTimeString) =>
      DateTime.Parse(startDateTimeString, CultureInfo.GetCultureInfo("da-DK"));
  }
}