using System.Text.Json.Serialization;
using FluentValidation;
using Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Validation;

namespace Lerbaek.NetDaemon.Apps.Integrations.Nordlux.Model;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Might exclude members from serialization.")]
public record Control(
    [property: JsonPropertyName("conName")] string Name,
    [property: JsonPropertyName("conValue")] string Value)
    : IJsonOnSerializing
{
    [JsonPropertyName("conModel")]
    public int Model => 4867;

    public void OnSerializing()
    {
        ControlValidator.Instance.ValidateAndThrow(this);
    }
}