using FluentAssertions;
using FluentAssertions.Execution;
using Lerbaek.NetDaemon.Common.Notifications;
using Lerbaek.Test.Common.Bases.TestClass;
using Xunit;
using Xunit.Abstractions;
using static Lerbaek.NetDaemon.Common.Notifications.Configuration;
using static Lerbaek.NetDaemon.Common.Notifications.VoiceNotificationVolume;

namespace Lerbaek.NetDaemon.Test.Common.Notifications;

[Collection(nameof(VoiceNotificationBuilder))]
public class VoiceNotificationBuilderTests(ITestOutputHelper output, INotificationBuilder notificationBuilder)
  : LoggerTestsBase(output)
{
  private const string TtsTextValue = "Test";
  private readonly IVoiceNotificationBuilder _uut = notificationBuilder.MakeVoiceNotification(TtsTextValue, Default);

  public static TheoryData<VoiceNotificationVolume> Volumes =>
    new(Enum.GetValues<VoiceNotificationVolume>());

  [Theory]
  [MemberData(nameof(Volumes))]
  public void NotificationBuilder_MakeVoiceNotification_PropertiesAreCorrectlySet(VoiceNotificationVolume volume)
  {
    _uut.SetVolume(volume);
    _uut.Notify((message, title, target, data) =>
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