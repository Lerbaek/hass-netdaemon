namespace Lerbaek.NetDaemon.Common.Converters;

public record Spectrum(int From, int To);

public static class SpectrumConverter
{
  public static int ShiftRange(this int input, Spectrum oldSpectrum, Spectrum newSpectrum)
  {
    var oldRangeLength = oldSpectrum.To - oldSpectrum.From; // Possible input values count
    var inputDelta = input - oldSpectrum.From;              // 0-based input value
    var per1 = (decimal)inputDelta / oldRangeLength;        // Input ratio (0 - 1)

    var newRangeLength = newSpectrum.To - newSpectrum.From; // Possible output values count
    var outputDelta = per1 * newRangeLength;                // 0-based output value
    var output = outputDelta + newSpectrum.From;            // Shifted output value

    return (int)Math.Ceiling(output);                       // Rounded output value, avoiding 0 by using Ceiling
  }

  public static int Reverse(this int input, Spectrum spectrum) => spectrum.From + spectrum.To - input;
}