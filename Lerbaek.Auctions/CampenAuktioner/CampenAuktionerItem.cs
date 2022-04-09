using System;
using Newtonsoft.Json.Linq;

namespace Lerbaek.Auctions.CampenAuktioner
{
  public class CampenAuktionerItem : AuctionItem
  {
    public CampenAuktionerItem(JToken jToken)
    {
      Description = jToken["description"]?.ToString();
      
      if (string.IsNullOrWhiteSpace(Description))
        return;
      
      var lotStatusToken = jToken["lotStatus"];
      TimeLeft = new TimeSpan(0, 0, (int)lotStatusToken["timeLeftSeconds"]);
      MinBid = (int)lotStatusToken["minBid"];
      
      if (TimeLeft < TimeSpan.Zero)
        return;
      
      Id = $"{jToken["eventItemId"]}";
      Link = new Uri($"https://campenauktioner.hibid.com/lot/{jToken["eventItemId"]}/");
      
      var imageLink = jToken["featuredPicture"]?["fullSizeLocation"]?.ToString();
      ImageLink = new Uri(string.IsNullOrWhiteSpace(imageLink)
        ? "https://campenauktioner.hibid.com/Styles/images/missing/image_en.png"
        : imageLink);
      
      City = $"{jToken["auctionZip"]} {jToken["auctionCity"]}";
      Title = jToken["lead"].ToString();
      Active = true;
    }
  }
}