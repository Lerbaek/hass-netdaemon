using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentResults;
using HtmlAgilityPack;
using Lerbaek.Lectio;
using Microsoft.Extensions.Logging;
using RegExtract;

namespace Lerbaek.Calendar.Lectio
{
  public class LectioCalendarModel : CalendarModel
  {
    private readonly LectioModel lectioModel;

    public LectioCalendarModel(LectioModel lectioModel) : base(lectioModel.Logger) => this.lectioModel = lectioModel;

    public override async Task<Result<IEnumerable<IEventModel>>> GetEvents()
    {
      var doc = new HtmlDocument();
      Logger.LogDebug("Trying to get schedule from Lectio.");
      if (!await TryGetSchedule(doc))
      {
        Logger.LogDebug("Could not get schedule. Logging in.");
        var loginResult = await lectioModel.Login();
        if (loginResult.IsFailed)
          return Result.Fail(loginResult.Errors);
        Logger.LogDebug("Getting schedule from Lectio.");
        await TryGetSchedule(doc);
      }

      Logger.LogDebug("Parsing for class ID's.");
      var classIds = doc
        .DocumentNode
        .Descendants()
        .Where(node => node.HasClass("entitylinklistH"))
        .SelectMany(node => node
          .Descendants("a")
          .Select(a => a
            .GetAttributeValue<string>("href", null)
            .Extract<string>("(?<=holdelementid=)\\d*")))
        .ToArray();

      Logger.LogTrace("Class ID's:{newLine}{classIds}", Environment.NewLine, string.Join(Environment.NewLine, classIds));

      Logger.LogDebug("Getting class schedules in parallel.");
      var tasks = classIds.Select(id => Task.Run(async () =>
      {
        var response = await lectioModel.HttpClient.GetAsync(
          $"https://www.lectio.dk/lectio/560/aktivitet/AktivitetListe2.aspx?holdelementid={id}");

        var classDoc = new HtmlDocument();
        classDoc.Load(await response.Content.ReadAsStreamAsync());
        var rows = classDoc.DocumentNode.SelectNodes("//td[contains(@class, 'ls-activity-col')]");
        return rows;
      }));

      var classes = await Task.WhenAll(tasks);

      Logger.LogDebug("HTML for all class schedules retrieved.");

      var classesWithScheduleResult = classes.Where(@class => !(@class is null))
        .SelectMany(@class => @class.Select(LectioClassModel.Parse).ToArray()).ToArray();

      if (classesWithScheduleResult.Any(r => r.IsFailed))
      {
        var errorMessages = classesWithScheduleResult
          .Where(r => r.IsFailed)
          .SelectMany(r => r.Errors)
          .GroupBy(e => e)
          .Select(g => g.Key);
        return Result.Fail(errorMessages);
      }

      var classesWithSchedule = classesWithScheduleResult.Select(r => r.Value).ToArray();
      foreach (var classGroup in classesWithSchedule.GroupBy(c => c.Name))
        Logger.LogDebug("{Name}: Found {LessonCount} lessons.", classGroup.Key, $"{classGroup.Count()}");

      Logger.LogInformation("Successfully retrieved {CalendarEventCount} calendar events.", $"{classesWithScheduleResult.Length}");

      return Result.Ok((IEnumerable<IEventModel>)classesWithSchedule);
    }

    private async Task<bool> TryGetSchedule(HtmlDocument doc)
    {
      return await lectioModel.TryGetPage(
        new Uri(
          $"https://www.lectio.dk/lectio/560/SkemaNy.aspx?type=elev&elevid={lectioModel.StudentId}"),
        doc);
    }
  }
}