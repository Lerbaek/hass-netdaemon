using System;
using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.Serialization;
using Lerbaek.Calendar.Lectio;
using Lerbaek.Test.Common.Bases.TestClass;
using Xunit;
using Xunit.Abstractions;

namespace Lerbaek.Calendar.Test
{
  [Collection(nameof(LectioCalendarModel))]
  public class LectioModelTests : HttpClientModelTestsBase
  {
    private readonly LectioCalendarModel uut = null!;

    public LectioModelTests(IHttpClientFactory httpClientFactory, ITestOutputHelper output)
      : base(httpClientFactory, output)
    {
    }

    [Fact]
    public async Task GetSchedule()
    {
    }
  }
}