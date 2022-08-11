using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using RegExtract;

namespace Lerbaek.RegEx
{
  public static class RegularExpressions
  {
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

    public static bool TryRegExtract<T>(this string str, string rx, out T result, out string error)
    {
      try
      {
        result = str.Extract<T>(rx);
        error = null;
        return true;
      }
      catch
      {
        result = default;
        error = $"No match for the regular expression \"{rx}\" was found in \"{str}\"";
        return false;
      }
    }
  }
}
