using System.Text.Json;
using Version = System.Version;

namespace Lerbaek.NetDaemon.Common.Converters.Json;

public class VersionConverter : System.Text.Json.Serialization.JsonConverter<Version>
{
    public override Version Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return Version.Parse(reader.GetString()?.TrimStart('v') ?? "0.0");
    }

    public override void Write(Utf8JsonWriter writer, Version value, JsonSerializerOptions options)
    {
        value = value.Build < 0 ? new Version(value.Major, value.Minor, 0) : value;
        writer.WriteStringValue($"v{value}");
    }
}