using System;
using Lerbaek.RegEx;

namespace Lerbaek.Stores.RegularExpressions.ProShop
{
  public static class RegularExpressionExtensions
  {
    public static bool TryGetProductId(this Uri url, out string productItemId, out string error) =>
      url.AbsoluteUri.TryRegExtract(GenericRegularExpressions.LastDigitInUrl, out productItemId, out error);
  }
}