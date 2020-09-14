using System;
using System.Collections.Generic;
using Xunit;

public class ClockComparableTests
{
    [Fact]
    public void Equality()
    {
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(3, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(2, 60)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(1, 120)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(0, 180)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(75, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(51, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(27, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(26, 60)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(25, 120)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(24, 180)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(-new Clock(21, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(-new Clock(20, 60)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(-new Clock(19, 120)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(-new Clock(18, 180)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(-new Clock(0, 1_260)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(-21, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(-20, -60)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(-19, -120)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(-18, -180)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(new Clock(0, -1_260)));
    }

    [Fact]
    public void GreaterThan()
    {
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(22, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(22, 59)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(22, 01)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(23, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(23, 59)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(23, 01)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(24, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(-22, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(-22, -59)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(-22, -01)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(-23, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(-23, -59)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(-23, -01)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(-24, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(0, -1_261)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(0, -1_380)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(0, -1_320)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(0, -1_410)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(0, -1_437)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(0, -1_429)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(24, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(48, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(new Clock(72, 0)));
    }

    [Fact]
    public void LesserThan()
    {
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(24, 59)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(24, 01)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(3, 0)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(2, 60)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(1, 120)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(0, 180)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(new Clock(-24, -59)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(new Clock(-24, -01)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(new Clock(-3, 0)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(new Clock(-2, -60)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(new Clock(-1, -120)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(new Clock(0, -180)));
    }

    [Fact]
    public void Equality_object()
    {
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(3, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(2, 60)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(1, 120)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(0, 180)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(75, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(51, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(27, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(26, 60)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(25, 120)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(24, 180)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(-new Clock(21, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(-new Clock(20, 60)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(-new Clock(19, 120)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(-new Clock(18, 180)));
        Assert.Equal(0, new Clock(3, 0).CompareTo(-new Clock(0, 1_260)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(-21, 0)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(-20, -60)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(-19, -120)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(-18, -180)));
        Assert.Equal(0, new Clock(3, 0).CompareTo((object)new Clock(0, -1_260)));
    }

    [Fact]
    public void GreaterThan_object()
    {
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(22, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(22, 59)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(22, 01)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(23, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(23, 59)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(23, 01)));
        Assert.Equal(1, new Clock(3, 0).CompareTo(-new Clock(24, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(-22, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(-22, -59)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(-22, -01)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(-23, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(-23, -59)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(-23, -01)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(-24, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(0, -1_261)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(0, -1_380)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(0, -1_320)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(0, -1_410)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(0, -1_437)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(0, -1_429)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(24, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(48, 0)));
        Assert.Equal(1, new Clock(3, 0).CompareTo((object)new Clock(72, 0)));
    }

    [Fact]
    public void LesserThan_object()
    {
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(24, 59)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(24, 01)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(3, 0)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(2, 60)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(1, 120)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo(-new Clock(0, 180)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo((object)new Clock(-24, -59)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo((object)new Clock(-24, -01)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo((object)new Clock(-3, 0)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo((object)new Clock(-2, -60)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo((object)new Clock(-1, -120)));
        Assert.Equal(-1, new Clock(3, 0).CompareTo((object)new Clock(0, -180)));
    }

    [Fact]
    public void CompareTo_Object_throws_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Clock(3, 0).CompareTo(new object()));
    }

    [Fact]
    public void CompareTo_List_throws_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Clock(3, 0).CompareTo(new List<Clock> { new Clock(01,01) }));
    }

    [Fact]
    public void CompareTo_String_throws_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Clock(3, 0).CompareTo("teste"));
        Assert.Throws<ArgumentException>(() => new Clock(3, 0).CompareTo(string.Empty));
    }

    [Fact]
    public void Equals_Object_throws_ArgumentException()
    {
        Assert.False(new Clock(3, 0).Equals(new object()));
    }

    [Fact]
    public void Equals_List_throws_ArgumentException()
    {
        Assert.False(new Clock(3, 0).Equals(new List<Clock> { new Clock(01, 01) }));
    }

    [Fact]
    public void Equals_String_throws_ArgumentException()
    {
        Assert.False(new Clock(3, 0).Equals("teste"));
        Assert.False(new Clock(3, 0).Equals(string.Empty));
    }

    [Fact]
    public void Default_sorting()
    {
        var input = new List<Clock> { new Clock(03, 00), new Clock(27, 01), new Clock(01, 02), -new Clock(21, 30) };
        var expected = new List<Clock> { new Clock(01, 02), -new Clock(21, 30), new Clock(03, 00), new Clock(27, 01) };
        input.Sort();

        Assert.Equal(expected, input);
    }

    [Fact]
    public void Ascending_sorting()
    {
        var input = new List<Clock> { new Clock(03, 00), new Clock(27, 01), new Clock(01, 02), -new Clock(21, 30) };
        var expected = new List<Clock> { new Clock(01, 02), -new Clock(21, 30), new Clock(03, 00), new Clock(27, 01) };
        input.Sort(ClockComparer.Ascending);

        Assert.Equal(expected, input);
    }

    [Fact]
    public void Descending_sorting()
    {
        var input = new List<Clock> { new Clock(03, 00), new Clock(27, 01), new Clock(01, 02), -new Clock(21, 30) };
        var expected = new List<Clock> { new Clock(27, 01), new Clock(03, 00) , - new Clock(21, 30), new Clock(01, 02) };
        input.Sort(ClockComparer.Descending);

        Assert.Equal(expected, input);
    }

    [Fact]
    public void Descending_hour_ascending_minute_sorting()
    {
        var input = new List<Clock> { new Clock(27, 49), new Clock(03, 00), new Clock(27, 01), new Clock(01, 02), -new Clock(21, 30), new Clock(03, 15) };
        var expected = new List<Clock> { new Clock(03, 00), new Clock(27, 01), new Clock(03, 15), new Clock(27, 49), -new Clock(21, 30), new Clock(01, 02) };

        input.Sort(ClockComparer.DescendingHourAscendingMinutes);

        Assert.Equal(expected, input);
    }
}
