namespace Lerbaek.NetDaemon.Apps.Integrations.CampenAuktioner;

public partial class CampenAuktioner
{
  public class Item
  {
    public bool Active { get; }
    public string? Id { get; }
    public Uri? Link { get; }
    public Uri? ImageLink { get; }
    public string? City { get; }
    public string? Title { get; }
    public string? Description { get; }
    public TimeSpan? TimeLeft { get; }
    public int? MinBid { get; }

    public Item(JToken jToken)
    {
      Description = jToken["description"]?.ToString();
      if (string.IsNullOrWhiteSpace(Description))
        return;
      var lotStatusToken = jToken["lotStatus"]!;
      TimeLeft = new TimeSpan(0, 0, (int)lotStatusToken["timeLeftSeconds"]!);
      MinBid = (int)lotStatusToken["minBid"]!;
      if (TimeLeft < TimeSpan.Zero)
        return;
      Id = $"{jToken["eventItemId"]}";
      Link = new Uri($"https://campenauktioner.hibid.com/lot/{jToken["eventItemId"]}/");
      var imageLink = jToken["featuredPicture"]?["fullSizeLocation"]?.ToString()!;
      ImageLink = new Uri(string.IsNullOrWhiteSpace(imageLink) ? "https://campenauktioner.hibid.com/Styles/images/missing/image_en.png" : imageLink);
      City = $"{jToken["auctionZip"]} {jToken["auctionCity"]}";
      Title = jToken["lead"]!.ToString();
      Active = true;
    }

    public bool Matches(IEnumerable<IEnumerable<IGrouping<bool, string>>> matchList)
    {
      var productInfo = $"{Title}{Environment.NewLine}{Description}".ToLowerInvariant();
      return matchList.Select(match => match as IGrouping<bool, string>[] ?? match.ToArray())
        .Any(grouping => grouping.Where(g => g.Key)
                           .SelectMany(g => g.ToList())
                           .All(productInfo.Contains)
                         &&
                         !grouping.Where(g => !g.Key)
                           .SelectMany(g => g.ToList()
                             .Select(l => l.TrimStart('-')))
                           .Any(productInfo.Contains));
    }

    public string Markdown =>
      @$"**[{Title}]({Link})**  
*{DateTime.Now + TimeLeft:dd/MM-yyyy HH:mm:ss}*  
{MinBid},-  
{City}

{Description}

[![{Title}]({ImageLink})]({Link})
";
  }
}