using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Lerbaek.Auctions.CampenAuktioner;
using Microsoft.Extensions.Logging;

namespace Lerbaek.Auctions
{
  public abstract class AuctionSite<TItem> where TItem : AuctionItem
  {
    protected readonly ILogger Logger;
    protected readonly HttpClient HttpClient;
    private Dictionary<HttpClient, CancellationTokenSource> cancellationTokens;

    /// <summary>
    /// When called, this property always cancels the old instance and returns a new one.
    /// </summary>
    protected CancellationTokenSource CancellationTokenSource
    {
      get
      {
        if (cancellationTokens.ContainsKey(HttpClient))
          cancellationTokens[HttpClient].Cancel();
        return cancellationTokens[HttpClient] = new CancellationTokenSource();
      }
    }

    protected AuctionSite(ILogger logger, HttpClient httpClient)
    {
      Logger = logger;
      HttpClient = httpClient;
      cancellationTokens = new Dictionary<HttpClient, CancellationTokenSource>();
    }


    /// <summary>
    /// Get a list of all matching auction items.
    /// </summary>
    /// <param name="searchTerms">
    /// A list of search terms. All terms must be included in either <see cref="AuctionItem.Title"/>
    /// or <see cref="AuctionItem.Description"/>, unless preceded by a dash, in which case they may
    /// not be included in either.
    /// </param>
    /// <inheritdoc cref="CancellationToken.ThrowIfCancellationRequested"/>
    public abstract Task<IEnumerable<TItem>> GetMatchesAsync(IEnumerable<string> searchTerms);

    /// <param name="predicate">Must be true for an item to be included.</param>
    /// <inheritdoc cref="GetMatchesAsync(IEnumerable{string})"/>
    public abstract Task<IEnumerable<CampenAuktionerItem>> GetMatchesAsync(Func<CampenAuktionerItem, bool> predicate = null);
  }
}