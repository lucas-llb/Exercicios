using System;
public partial class Clock : IEquatable<Clock>
{
    /// <summary>
    /// Returns a positive clock.
    /// </summary>
    public static Clock operator +(Clock clock) => new Clock(clock.Hours, clock.Minutes);

    /// <summary>
    /// Returns a negative clock (makes both hours and minutes negative).
    /// </summary>
    public static Clock operator -(Clock clock) => new Clock(-clock.Hours, -clock.Minutes);

    /// <summary>
    /// Increments the clock in one minute.
    /// </summary>
    public static Clock operator ++(Clock clock) =>
        clock.Add(1);

    /// <summary>
    /// Decrements the clock in one minute.
    /// </summary>
    public static Clock operator --(Clock clock) =>
        clock.Subtract(1);

    /// <summary>
    /// Adds one clocktime to another.
    /// </summary>
    public static Clock operator +(Clock one, Clock another) =>
        new Clock(one.Hours + another.Hours, one.Minutes + another.Minutes);

    /// <summary>
    /// Subtracts the time of a clock from another clock time.
    /// </summary>
    public static Clock operator -(Clock one, Clock another) =>
        new Clock(one.Hours - another.Hours, one.Minutes - another.Minutes);

    /// <summary>
    /// Adds a specified minutes amount to a clock.
    /// </summary>
    public static Clock operator +(Clock clock, int minutes) =>
        new Clock(clock.Hours, clock.Minutes + minutes);

    /// <summary>
    /// Subtracts a specified minutes amount to a clock.
    /// </summary>
    public static Clock operator -(Clock clock, int minutes) =>
        new Clock(clock.Hours, clock.Minutes - minutes);

    /// <summary>
    /// Multiplies the total amount of minutes by a specified factor.
    /// </summary>
    public static Clock operator *(Clock clock, int value) =>
        new Clock(clock.ToMinutes() * value);

    /// <summary>
    /// Divides the total amount of minutes by a specified factor.
    /// </summary>
    public static Clock operator /(Clock clock, int value) =>
        new Clock(clock.ToMinutes() / value);

    /// <summary>
    /// Compares the equality of a clock with any othe object, including clocks.
    /// When comparing two clocks, compares the value of them.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public static bool operator ==(Clock one, Clock another) =>
        one.Equals(another);

    /// <summary>
    /// Compares the inequality of a clock with any othe object, including clocks.
    /// When comparing two clocks, compares the value of them.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public static bool operator !=(Clock one, Clock another) =>
        !one.Equals(another);

    /// <summary>
    /// Compares a clock with any othe object, including clocks.
    /// When comparing two clocks, compares the value of them.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public static bool operator <(Clock one, Clock another) =>
        one.ToMinutes() < another.ToMinutes();

    /// <summary>
    /// Compares a clock with any othe object, including clocks.
    /// When comparing two clocks, compares the value of them.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public static bool operator >(Clock one, Clock another) =>
        one.ToMinutes() > another.ToMinutes();

    /// <summary>
    /// Compares a clock with any othe object, including clocks.
    /// When comparing two clocks, compares the value of them.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public static bool operator <=(Clock one, Clock another) =>
        one.ToMinutes() <= another.ToMinutes();

    /// <summary>
    /// Compares a clock with any othe object, including clocks.
    /// When comparing two clocks, compares the value of them.
    /// </summary>
    /// <remarks>When comparing two clocks, compares the value of them.</remarks>
    public static bool operator >=(Clock one, Clock another) =>
        one.ToMinutes() >= another.ToMinutes();
}
