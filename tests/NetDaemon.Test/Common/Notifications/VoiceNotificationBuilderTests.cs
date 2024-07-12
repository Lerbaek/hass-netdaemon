using FluentAssertions;
using FluentAssertions.Execution;
using Lerbaek.NetDaemon.Common.Notifications;
using Lerbaek.Test.Common.Bases.TestClass;
using Xunit;
using Xunit.Abstractions;
using static Lerbaek.NetDaemon.Common.Notifications.Configuration;
using static Lerbaek.NetDaemon.Common.Notifications.VoiceNotificationVolume;

namespace NetDaemon.Test.Common.Notifications;

[Collection(nameof(VoiceNotificationBuilder))]
public class VoiceNotificationBuilderTests : LoggerTestsBase
{
  private const string TtsTextValue = "Test";
  private readonly IVoiceNotificationBuilder uut;

  public VoiceNotificationBuilderTests(ITestOutputHelper output, INotificationBuilder notificationBuilder) : base(output)
  {
    uut = notificationBuilder.MakeVoiceNotification(TtsTextValue, Default);
  }

  public static IEnumerable<object[]> Volumes =>
    Enum.GetValues<VoiceNotificationVolume>()
        .Select(v => new object[] { v });

  [Theory]
  [MemberData(nameof(Volumes))]
  public void NotificationBuilder_MakeVoiceNotification_PropertiesAreCorrectlySet(VoiceNotificationVolume volume)
  {
    uut.SetVolume(volume);
    uut.Notify((message, title, target, data) =>
    {
      using (new AssertionScope())
      {
        message.Should().Be(Tts, "voice notifications should always have the value {TTS}", Tts);
        title.Should().BeNull("voice notifications have no {title}", nameof(title));
        target.Should().BeNull("it's not being used.");

        var dataDictionary = data.Should().BeOfType<Dictionary<string, object>>().Subject;
        dataDictionary.Should()
                      .ContainKey(TtsTextKey, "without it there's not point to a voice notification")
                      .WhoseValue
                      .Should()
                      .Be(TtsTextValue, "that's what was passed to the constructor");

        if(volume != Default)
          dataDictionary.Should()
                        .ContainKey(MediaStreamKey)
                        .WhoseValue
                        .Should()
                        .Be(VoiceNotificationVolumeStream[volume]);
      }
    });
  }
}