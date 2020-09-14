using System;
using System.Diagnostics.CodeAnalysis;

public partial class Clock : IEquatable<Clock>
{
    /// <summary>
    /// Compares the value of two different clocks.
    /// </summary>
    public bool Equals([AllowNull] Clock other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return Hours == other.Hours && Minutes == other.Minutes;
    }
}
