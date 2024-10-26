using System.Numerics;

namespace Lerbaek.NetDaemon.Common.Converters;

public static class SpectrumConverter
{
    public static readonly Spectrum PercentageSpectrum = new(1, 100);
    public static readonly Spectrum ByteSpectrum = new(3, 255);
    public static readonly Spectrum TemperatureSpectrum = new(153, 500);

    public static int ShiftRange<T>(this T input, Spectrum oldSpectrum, Spectrum newSpectrum) where T : INumber<T>
    {
        var oldRangeMax = oldSpectrum.To - oldSpectrum.From;          // 0-based input spectrum maximum
        var inputDelta = Convert.ToDecimal(input) - oldSpectrum.From; // 0-based input value
        var inputRatio = inputDelta / (oldRangeMax);                  // Input ratio (0 - 1)

        var newRangeMax = newSpectrum.To - newSpectrum.From;          // 0-based output spectrum maximum
        var outputDelta = inputRatio * newRangeMax;                   // 0-based output value
        var output = outputDelta + newSpectrum.From;                  // Shifted output value

        return Math.Max(newSpectrum.From, (int)Math.Round(output));   // Ensure that rounding error doesn't bring the value below the range
    }

    public static int Reverse(this int input, Spectrum spectrum)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(input, spectrum.From);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(input, spectrum.To);
        return spectrum.From + spectrum.To - input;
    }
}