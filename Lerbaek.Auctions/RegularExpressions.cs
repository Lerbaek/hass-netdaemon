using System;
using System.Collections.Generic;
using System.Linq;
using RegExtract;

namespace Lerbaek.Auctions
{
  public static class RegularExpressions
  {
    public const string AllWordsNotStartingWithDash = @"\b(?<!-)[^ ]+";
    public const string AllWordsStartingWithDash = @"\b(?<=-)[^ ]+";

    public static IEnumerable<T> SafeRegExtract<T>(this IEnumerable<string> terms, string rx)
    {
      try
      {
        return terms.Extract<T>(rx).ToArray();
      }
      catch (Exception)
      {
        return Array.Empty<T>();
      }
    }
  }
}