namespace Lerbaek.Auctions
{
  public static class RegularExpressions
  {
    public const string AllWordsNotStartingWithDash = @"\b(?<!-)[^ ]+";
    public const string AllWordsStartingWithDash = @"\b(?<=-)[^ ]+";
  }
}