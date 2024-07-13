using Lerbaek.Calendar.Lectio;
using Lerbaek.Test.Common.Bases.TestClass;
using Xunit;
using Xunit.Abstractions;

namespace Lerbaek.Calendar.Test
{
  [Collection(nameof(LectioCalendarModel))]
  public class LectioModelTests(IHttpClientFactory httpClientFactory, ITestOutputHelper output)
    : HttpClientModelTestsBase(httpClientFactory, output)
  {
    private readonly LectioCalendarModel uut = null!;

    [Fact]
    public async Task GetSchedule()
    {
    }
  }
}