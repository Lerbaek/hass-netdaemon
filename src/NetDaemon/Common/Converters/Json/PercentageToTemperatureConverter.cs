using System.Text.Json;

namespace Lerbaek.NetDaemon.Common.Converters.Json;

public class PercentageToTemperatureConverter : System.Text.Json.Serialization.JsonConverter<int>
{
    public static int ToTemperature(int temperature) => temperature + 800;
    public static int ToPercentage(int percentage) => percentage - 800;

    public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return ToPercentage(reader.GetInt32());
    }

    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
    {

        writer.WriteNumberValue(ToTemperature(value));
    }
}