using System;
using System.Runtime.CompilerServices;

/// <summary>
/// Class that represents a clock.
/// </summary>
public partial class Clock
{
    internal int Hours { get; }
    internal int Minutes { get; }

    /// <summary>
    /// Creates a clock from a given number of minutes.
    /// </summary>
    /// <param name="minutes">Given minutes to set the clock.</param>
    public Clock(int minutes):this(0, minutes)
    {
    }

    /// <summary>
    /// Creates a clock from hours and minutes.
    /// </summary>
    /// <param name="hours">Given hours to create the clock.</param>
    /// <param name="minutes">Given minutes to create the clock.</param>
    public Clock(int hours, int minutes)
    {
        Hours = (hours + (minutes / 60)) % 24;
        Minutes = minutes % 60;

        if (Minutes < 0)
        {
            Hours--;
            Minutes = 60 + Minutes;
        }

        if (Hours < 0)
        {
            Hours = 24 + Hours;
        }
    }

    public Clock Add(int minutesToAdd) => new Clock(Hours, Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new Clock(Hours, Minutes - minutesToSubtract);

    public int ToMinutes() => Hours * 60 + Minutes;

    /// <summary>
    /// Compares a clock with any othe object, including clocks.
    /// When comparing two clocks, compares the value of them.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is Clock clock && Equals(clock);
    }

    ///<summary>
    ///<para>If you are implementing a value type, you should consider overriding
    ///the <see cref="Equals"/> method to gain increased performance over the
    ///default implementation of the <see cref="Equals"/> method on <see cref="ValueType"/>.</para>
    ///<para>If you are implementing a reference type, you should consider overriding
    ///the <see cref="Equals"/> method if your type looks like a base type,
    ///such as <see cref="Point"/>, <see cref="String"/>, <see cref="BigNumber"/>, and so on.</para>
    ///<para>Override the <see cref="GetHashCode"/> method to allow a type to work
    ///correctly in a hash table.</para>
    ///<para>
    ///     <seealso href="https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=netcore-3.1#notes-to-inheritors">MS Documentation</seealso><br/>
    ///     <seealso href="http://www.isthe.com/chongo/tech/comp/fnv/">FNV hash implementation</seealso><br/>
    ///     <seealso href="https://stackoverflow.com/a/263416/412426">StackOverflow</seealso>
    /// </para>
    /// </summary>
    /// <remarks>
    /// Note that one thing to be aware of is that ideally you should prevent
    /// your equality-sensitive (and thus hashcode-sensitive) state from
    /// changing after adding it to a collection that depends on the hash code.
    /// </remarks>
    /// <example>
    ///     public override int GetHashCode()
    ///     {
    ///         unchecked // Overflow is fine, just wrap
    ///         {
    ///             int hash = (int)2166136261;
    ///             // Suitable nullity checks etc, of course :)
    ///             hash = (hash * 16777619) ^ Hours.GetHashCode();
    ///             hash = (hash * 16777619) ^ Minutes.GetHashCode();
    ///             return hash;
    ///         }
    ///     }
    /// </example>
    /// <returns></returns>
    public override int GetHashCode() => HashCode.Combine(Hours, Minutes);

    public override string ToString() => $"{Hours:D2}:{Minutes:D2}";
}
