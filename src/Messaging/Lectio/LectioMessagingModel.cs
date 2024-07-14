﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Lerbaek.Lectio;
using Microsoft.Extensions.Logging;
using RegExtract;

namespace Lerbaek.Messaging.Lectio
{
  public class LectioMessagingModel
  {
    private readonly LectioModel _lectioModel;

    public LectioMessagingModel(LectioModel lectioModel)
    {
      this._lectioModel = lectioModel;
    }

    public async Task<IEnumerable<LectioMessageModel>> GetMessagesAsync()
    {
      var doc = new HtmlDocument();
      _lectioModel.Logger.LogDebug("Trying to get messages from Lectio.");

      if (!await TryGetInbox(doc))
      {
        _lectioModel.Logger.LogDebug("Could not get messages. Logging in.");
        await _lectioModel.Login();
        _lectioModel.Logger.LogDebug("Getting messages from Lectio.");
        await TryGetInbox(doc);
      }

      var threadIds = doc
        .DocumentNode
        .SelectSingleNode("//*[@id=\"s_m_Content_Content_threadGV_ctl00\"]")
        .Descendants("a")
        .Where(a => a.Attributes.Contains("onclick"))
        .Select(a => a
          .GetAttributeValue("onclick", null)
          .Extract<string>("(?<=\\$_)\\d*"));

      var threadDocs = new List<HtmlDocument>();

      foreach (var threadId in threadIds)
      {
        var threadStream = await _lectioModel.HttpClient.GetStreamAsync(
          $"https://www.lectio.dk/lectio/560/beskeder2.aspx?type=showthread&elevid={_lectioModel.StudentId}&selectedfolderid=-10&id={threadId}");
        var threadDoc = new HtmlDocument();
        threadDoc.Load(threadStream);
        threadDocs.Add(threadDoc);
      }

      return null;
    }

    private async Task<bool> TryGetInbox(HtmlDocument doc)
    {
      return await _lectioModel.TryGetPage(
        new Uri(
          $"https://www.lectio.dk/lectio/560/beskeder2.aspx?type=&elevid={_lectioModel.StudentId}&selectedfolderid=-10"),
        doc);
    }
  }

  public class LectioMessageModel : IMessageModel
  {
    public string Title { get; }
    public string Message { get; }
    public string Sender { get; }
    public DateTime Time { get; }
    public Uri Link { get; }
    public Uri Image { get; }
  }

  public interface IMessageModel
  {
    string Title { get; }
    string Message { get; }
    string Sender { get; }
    DateTime Time { get; }
    Uri Link { get; }
  }
}