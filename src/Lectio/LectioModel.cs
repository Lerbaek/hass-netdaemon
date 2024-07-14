using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FluentResults;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using RegExtract;

namespace Lerbaek.Lectio
{
  public class LectioModel
  {
    public ILogger Logger { get; }
    public HttpClient HttpClient { get; }
    public long StudentId { get; private set; }= -1;
    private readonly LectioConfig _config;

    public LectioModel(LectioConfig config, ILogger logger, IHttpClientFactory httpClientFactory)
    {
      Logger = logger;
      _config = config;
      HttpClient = httpClientFactory.CreateClient(nameof(LectioModel));
    }

    public async Task<Result> Login()
    {
      var content = new FormUrlEncodedContent(new (string key, string value)[]
      {
        ("__EVENTARGUMENT", ""),
        ("__EVENTTARGET", "m$Content$submitbtn2"),
        ("__EVENTVALIDATION",
          "omkBP+/TrZoAdJ+61ALetpe9aIc9+oKC8am2FRCpce09OTzWV27VCGYz/vc3OXR6kT+giVxBuQ19h+kAB9pAGpd6C6FjK0z/RsTCRPMBgEfHnWjJQijGVPNMc63fptjoEPgV9wJPHlsrshdx3ZhypUdWdIGgSyLRZtfyAOGrmeqz60AK3C9B+qVHnozdgA2agsBUO2pMwau9lU1l1Vs/PXT0oCcR34ZnsomWqKZRygc="),
        ("m$Content$username", _config.Username),
        ("m$Content$password", _config.Password)
      }.Select(tuple => new KeyValuePair<string, string>(tuple.key, tuple.value)));

      Logger.LogInformation("Logging in to LectioModel with user: {username}", _config.Username);
      var response = await HttpClient.PostAsync("https://www.lectio.dk/lectio/560/login.aspx", content);
      Logger.LogDebug("Status code: {statusCode}", response.StatusCode);
      var doc = new HtmlDocument();
      doc.Load(await response.Content.ReadAsStreamAsync());

      if (doc.DocumentNode.InnerHtml.Contains("Fejl i Brugernavn og/eller adgangskode"))
      {
        return Result.Fail(LectioError.BadCredentials);
      }

      StudentId = doc
        .DocumentNode
        .SelectSingleNode("//meta[@name=\"msapplication-starturl\"]")
        .GetAttributeValue("content", null)
        .Extract<long>("(?<=elevid=)\\d*");

      Logger.LogDebug("Student ID resolved to {StudentId}", $"{StudentId}");

      Logger.LogTrace("Response: {msg}", doc.ParsedText);

      return Result.Ok();
    }

    public async Task<bool> TryGetPage(Uri uri, HtmlDocument doc)
    {
      if (StudentId < 0)
      {
        Logger.LogDebug("Student ID {StudentId} is invalid and needs to be resolved first.", $"{StudentId}");
        return false;
      }

      Logger.LogDebug("Student ID: {StudentId}", $"{StudentId}");
      var response =
        await HttpClient.GetAsync(uri);
      doc.Load(await response.Content.ReadAsStreamAsync());
      var title = doc.DocumentNode.SelectSingleNode("/html/head/title").InnerText;
      return !title.ToLowerInvariant().Contains("log ind");
    }
  }
}