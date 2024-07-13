using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Lerbaek.RegEx;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Lerbaek.Auctions.RegularExpressions;

namespace Lerbaek.Auctions.CampenAuktioner
{
  public class CampenAuktionerSite : AuctionSite<CampenAuktionerItem>
  {
    public CampenAuktionerSite(ILogger logger, HttpClient httpClient) : base(logger, httpClient)
    {
    }

    public override async Task<IEnumerable<CampenAuktionerItem>> GetMatchesAsync(IEnumerable<string> searchTerms)
    {

      var terms = searchTerms.Select(term => term.Trim()).ToArray();
      var includes = terms.Where(term => !term.StartsWith("-")).ToArray();
      var excludes = terms.Where(term => term.StartsWith("-")).ToArray();
      
      var results = await GetResults();
      var matches = results.Where(i => i.Matches(includes, excludes)).ToArray();
      LogMatchCount(matches);
      return matches;
    }

    public override async Task<IEnumerable<CampenAuktionerItem>> GetMatchesAsync(Func<CampenAuktionerItem, bool> predicate = null)
    {
      var results = await GetResults();
      var matches = results.Where(predicate ?? (_ => true)).ToArray();
      LogMatchCount(matches);
      return matches;
    }

    private void LogMatchCount(CampenAuktionerItem[] matches) =>
      Logger.LogDebug($"{{matchCount}} match{(matches.Length > 1 ? "es" : "")} found.", matches.Length);

    private async Task<IEnumerable<CampenAuktionerItem>> GetResults()
    {
      try
      {
        var cancellationToken = CancellationTokenSource.Token;
      
        var page1 = await GetPage(1, cancellationToken);

        var pageCountToken = page1["pageCount"];
        if (pageCountToken == null)
          throw new HttpRequestException("No page count")
          {
            Source = GetApiLink(1)
          };
      
        cancellationToken.ThrowIfCancellationRequested();

        var tasks = Enumerable
          .Range(2, pageCountToken.Value<int>() - 1)
          .Select(async page => await GetItemsAsync(page, cancellationToken));

        var page1Results = ParseItems(page1);
        var remainingResults = (await Task.WhenAll(tasks)).SelectMany(items => items);
        var results = page1Results.Concat(remainingResults);

        cancellationToken.ThrowIfCancellationRequested();

        return results.OrderBy(r => r.TimeLeft);
      }
      catch (TaskCanceledException e)
      {
        Logger.LogInformation(e, "Task cancelled because a new search was started");
        return Enumerable.Empty<CampenAuktionerItem>();
      }
    }

    private void LogPageRetrieved(int pageNo)
    {
      Logger.LogDebug("Retrieved page {page}", pageNo);
    }

    private async Task<CampenAuktionerItem[]> GetItemsAsync(int page, CancellationToken cancellationToken)
    {
      try
      {
        cancellationToken.ThrowIfCancellationRequested();
        var pageResult = await GetPage(page, cancellationToken);
        var items = ParseItems(pageResult).ToArray();
        return items;
      }
      catch (Exception e) when (!(e is OperationCanceledException))
      {
        Logger.LogWarning(e, "Failed to get page {page}", page);
        throw;
      }
    }

    private static IEnumerable<CampenAuktionerItem> ParseItems(JObject page) =>
      page?["results"]
        .Select(r => new CampenAuktionerItem(r))
        .Where(item => item.Active) ??
      throw new ArgumentNullException(nameof(page));

    private async Task<JObject> GetPage(int page, CancellationToken cancellationToken)
    {
      cancellationToken.ThrowIfCancellationRequested();
      try
      {
        var apiLink = GetApiLink(page);
        using (var stream = await HttpClient.GetStreamAsync(apiLink))
        using (var streamReader = new StreamReader(stream))
        using (JsonReader jsonReader = new JsonTextReader(streamReader))
          return await JObject.LoadAsync(jsonReader, cancellationToken);
      }
      catch (Exception e) when (!(e is TaskCanceledException ||
                                  e is HttpRequestException))
      {
        System.Diagnostics.Debugger.Break();
        throw;
      }
    }

    private static string GetApiLink(int page) =>
      $"http://campenauktioner.hibid.com/api/v1/lot/list?pn={page}&ipp=100&isArchive=false";
  }
}
