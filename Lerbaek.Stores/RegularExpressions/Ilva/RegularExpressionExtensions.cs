using System;
using Lerbaek.RegEx;

namespace Lerbaek.Stores.RegularExpressions.Ilva
{
  public static class RegularExpressionExtensions
  {
    public static bool TryGetProductItemId(this Uri url, out string productItemId, out string error) =>
      url.AbsoluteUri.TryRegExtract(@"(?<=\/p-).*(?=-\d+\/?$)", out productItemId, out error);

    public static bool TryGetVariantErp(this Uri url, out string variantErp, out string error) =>
      url.AbsoluteUri.TryRegExtract(GenericRegularExpressions.LastDigitInUrl, out variantErp, out error);
  }
}