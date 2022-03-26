namespace Lerbaek.NetDaemon.Common.Converters;

public static class RangeConverter
{
  public static int ShiftRange(this int input, (int from, int to) oldRange, (int from, int to) newRange)
  {
    var oldRangeLength = oldRange.to - oldRange.from; // Possible input values count
    var inputDelta = input - oldRange.from;           // 0-based input value
    var per1 = (decimal)inputDelta / oldRangeLength;  // Input ratio (0 - 1)

    var newRangeLength = newRange.to - newRange.from; // Possible output values count
    var outputDelta = per1 * newRangeLength;          // 0-based output value
    var output = outputDelta + newRange.from;         // Shifted output value

    return (int)Math.Ceiling(output);                 // Rounded output value, avoiding 0 by using Ceiling
  }

  public static int Reverse(this int input, (int from, int to) range) => range.from + range.to - input;
}