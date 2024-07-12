using System;
using System.Collections.Generic;
using System.Linq;
using static System.Environment;

namespace Lerbaek.Auctions
{
  public class AuctionItem
  {
    public bool Active { get; protected set; }
    public string Id { get; protected set; }
    public Uri Link { get; protected set; }
    public Uri ImageLink { get; protected set; }
    public string City { get; protected set; }
    public string Title { get; protected set; }
    public string Description { get; protected set; }
    public TimeSpan? TimeLeft { get; protected set; }
    public int? MinBid { get; protected set; }

    public string Markdown => $@"
**[{Title}]({Link})**  
*{DateTime.Now + TimeLeft:dd/MM-yyyy HH:mm:ss}*  
{MinBid},-  
{City}

{Description}

[![{Title}]({ImageLink})]({Link})
".TrimStart();

    public bool Matches(IEnumerable<string> searchTerms, IEnumerable<string> blacklist)
    {
      var productInfo = $"{Title}{NewLine}{Description}".ToLowerInvariant();
      return searchTerms.Any(term => productInfo.Contains(term.ToLowerInvariant())) &&
             !blacklist .Any(term => productInfo.Contains(term.ToLowerInvariant()));
    }
  }
}