using System.Text.Json;

namespace Lerbaek.NetDaemon.Common.Converters.Json;

public class BoolToIntConverter : System.Text.Json.Serialization.JsonConverter<bool>
{
    public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetInt32() == 1;
    }

    public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value ? 1 : 0);
    }
}