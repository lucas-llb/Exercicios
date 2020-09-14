using Xunit;

public class ClockOperatorTests
{
    [Fact]
    public void Negative_without_minutes()
    {
        var sut = new Clock(8, 0);
        Assert.Equal("08:00", sut.ToString());

        Assert.Equal("16:00", (-sut).ToString());
    }

    [Fact]
    public void Negative_with_minutes()
    {
        var sut = new Clock(0, 8);
        Assert.Equal("00:08", sut.ToString());

        Assert.Equal("23:52", (-sut).ToString());
    }

    [Fact]
    public void Increment_does_not_change_hour()
    {
        var sut = new Clock(8, 0);
        Assert.Equal("08:00", sut.ToString());

        sut++;
        Assert.Equal("08:01", sut.ToString());

        ++sut;
        Assert.Equal("08:02", sut.ToString());
    }

    [Fact]
    public void Increment_changes_hour()
    {
        var sut = new Clock(8, 59);
        Assert.Equal("08:59", sut.ToString());

        sut++;
        Assert.Equal("09:00", sut.ToString());

        sut = new Clock(8, 59);

        ++sut;
        Assert.Equal("09:00", sut.ToString());
    }

    [Fact]
    public void Decrement_does_not_change_hour()
    {
        var sut = new Clock(8, 2);
        Assert.Equal("08:02", sut.ToString());

        sut--;
        Assert.Equal("08:01", sut.ToString());

        --sut;
        Assert.Equal("08:00", sut.ToString());
    }

    [Fact]
    public void Decrement_changes_hour()
    {
        var sut = new Clock(8, 0);
        Assert.Equal("08:00", sut.ToString());

        sut--;
        Assert.Equal("07:59", sut.ToString());

        --sut;
        Assert.Equal("07:58", sut.ToString());
    }

    [Fact]
    public void Add_changes_day()
    {
        var sut = new Clock(8, 0) + new Clock(17, 0);
        Assert.Equal("01:00", sut.ToString());
    }

    [Fact]
    public void Add_does_not_change_day()
    {
        var sut = new Clock(8, 0) + new Clock(7, 0);
        Assert.Equal("15:00", sut.ToString());
    }

    [Fact]
    public void Subtract_changes_day()
    {
        var sut = new Clock(8, 0) - new Clock(17, 0);
        Assert.Equal("15:00", sut.ToString());
    }

    [Fact]
    public void Subtract_does_not_change_day()
    {
        var sut = new Clock(8, 0) - new Clock(7, 0);
        Assert.Equal("01:00", sut.ToString());
    }

    [Fact]
    public void Add_minutes_changes_day()
    {
        var sut = new Clock(8, 0) + 1_020;
        Assert.Equal("01:00", sut.ToString());
    }

    [Fact]
    public void Add_minutes_does_not_change_day()
    {
        var sut = new Clock(8, 0) + 420;
        Assert.Equal("15:00", sut.ToString());
    }

    [Fact]
    public void Subtract_minutes_changes_day()
    {
        var sut = new Clock(8, 0) - 1_020;
        Assert.Equal("15:00", sut.ToString());
    }

    [Fact]
    public void Subtract_minutes_does_not_change_day()
    {
        var sut = new Clock(8, 0) - 420;
        Assert.Equal("01:00", sut.ToString());
    }

    [Fact]
    public void Multiply_changes_day()
    {
        var sut = new Clock(8, 0) * 3;
        Assert.Equal("00:00", sut.ToString());

        sut = new Clock(8, 0) * 4;
        Assert.Equal("08:00", sut.ToString());

        sut = new Clock(8, 0) * 5;
        Assert.Equal("16:00", sut.ToString());
    }

    [Fact]
    public void Multiply_does_not_change_day()
    {
        var sut = new Clock(8, 0) * 2;
        Assert.Equal("16:00", sut.ToString());

        sut = new Clock(4, 22) * 3;
        Assert.Equal("13:06", sut.ToString());
    }

    [Fact]
    public void Divides_leaves_only_minutes()
    {
        var sut = new Clock(8, 0) / 9;
        Assert.Equal("00:53", sut.ToString());

        sut = new Clock(8, 0) / 10;
        Assert.Equal("00:48", sut.ToString());

        sut = new Clock(8, 0) / 11;
        Assert.Equal("00:43", sut.ToString());

        sut = new Clock(8, 0) / 12;
        Assert.Equal("00:40", sut.ToString());

        sut = new Clock(8, 0) / 13;
        Assert.Equal("00:36", sut.ToString());

        sut = new Clock(8, 0) / 14;
        Assert.Equal("00:34", sut.ToString());

        sut = new Clock(8, 0) / 15;
        Assert.Equal("00:32", sut.ToString());

        sut = new Clock(8, 0) / 16;
        Assert.Equal("00:30", sut.ToString());

        sut = new Clock(8, 0) / 17;
        Assert.Equal("00:28", sut.ToString());

        sut = new Clock(8, 0) / 18;
        Assert.Equal("00:26", sut.ToString());

        sut = new Clock(8, 0) / 19;
        Assert.Equal("00:25", sut.ToString());

        sut = new Clock(8, 0) / 20;
        Assert.Equal("00:24", sut.ToString());

        sut = new Clock(8, 0) / 21;
        Assert.Equal("00:22", sut.ToString());

        sut = new Clock(8, 0) / 22;
        Assert.Equal("00:21", sut.ToString());

        sut = new Clock(8, 0) / 23;
        Assert.Equal("00:20", sut.ToString());

        sut = new Clock(8, 0) / 32;
        Assert.Equal("00:15", sut.ToString());

        sut = new Clock(8, 0) / 44;
        Assert.Equal("00:10", sut.ToString());

        sut = new Clock(8, 0) / 45;
        Assert.Equal("00:10", sut.ToString());

        sut = new Clock(8, 0) / 46;
        Assert.Equal("00:10", sut.ToString());

        sut = new Clock(8, 0) / 47;
        Assert.Equal("00:10", sut.ToString());

        sut = new Clock(8, 0) / 48;
        Assert.Equal("00:10", sut.ToString());

        sut = new Clock(8, 0) / 45;
        Assert.Equal("00:10", sut.ToString());

        sut = new Clock(8, 0) / 80;
        Assert.Equal("00:06", sut.ToString());

        sut = new Clock(8, 0) / 81;
        Assert.Equal("00:05", sut.ToString());

        sut = new Clock(8, 0) / 85;
        Assert.Equal("00:05", sut.ToString());

        sut = new Clock(8, 0) / 90;
        Assert.Equal("00:05", sut.ToString());

        sut = new Clock(8, 0) / 95;
        Assert.Equal("00:05", sut.ToString());

        sut = new Clock(8, 0) / 96;
        Assert.Equal("00:05", sut.ToString());

        sut = new Clock(8, 0) / 97;
        Assert.Equal("00:04", sut.ToString());

        sut = new Clock(8, 0) / 100;
        Assert.Equal("00:04", sut.ToString());

        sut = new Clock(8, 0) / 110;
        Assert.Equal("00:04", sut.ToString());

        sut = new Clock(8, 0) / 120;
        Assert.Equal("00:04", sut.ToString());

        sut = new Clock(8, 0) / 160;
        Assert.Equal("00:03", sut.ToString());

        sut = new Clock(8, 0) / 240;
        Assert.Equal("00:02", sut.ToString());

        sut = new Clock(8, 0) / 320;
        Assert.Equal("00:01", sut.ToString());

        sut = new Clock(8, 0) / 480;
        Assert.Equal("00:01", sut.ToString());

        sut = new Clock(8, 0) / 500;
        Assert.Equal("00:00", sut.ToString());
    }

    [Fact]
    public void Divides_does_not_change_day()
    {
        var sut = new Clock(8, 0) / 4;
        Assert.Equal("02:00", sut.ToString());

        sut = new Clock(8, 0) / 3;
        Assert.Equal("02:40", sut.ToString());

        sut = new Clock(8, 0) / 5;
        Assert.Equal("01:36", sut.ToString());

        sut = new Clock(8, 0) / 6;
        Assert.Equal("01:20", sut.ToString());

        sut = new Clock(8, 0) / 7;
        Assert.Equal("01:08", sut.ToString());

        sut = new Clock(8, 0) / 8;
        Assert.Equal("01:00", sut.ToString());
    }

    [Fact]
    public void Equality()
    {
        Assert.True(new Clock(3, 0) == new Clock(3, 0));
        Assert.True(new Clock(3, 0) == new Clock(2, 60));
        Assert.True(new Clock(3, 0) == new Clock(1, 120));
        Assert.True(new Clock(3, 0) == new Clock(0, 180));
        Assert.True(new Clock(3, 0) == new Clock(75, 0));
        Assert.True(new Clock(3, 0) == new Clock(51, 0));
        Assert.True(new Clock(3, 0) == new Clock(27, 0));
        Assert.True(new Clock(3, 0) == new Clock(26, 60));
        Assert.True(new Clock(3, 0) == new Clock(25, 120));
        Assert.True(new Clock(3, 0) == new Clock(24, 180));
        Assert.True(new Clock(3, 0) == -new Clock(21, 0));
        Assert.True(new Clock(3, 0) == -new Clock(20, 60));
        Assert.True(new Clock(3, 0) == -new Clock(19, 120));
        Assert.True(new Clock(3, 0) == -new Clock(18, 180));
        Assert.True(new Clock(3, 0) == -new Clock(0, 1_260));
        Assert.True(new Clock(3, 0) == new Clock(-21, 0));
        Assert.True(new Clock(3, 0) == new Clock(-20, -60));
        Assert.True(new Clock(3, 0) == new Clock(-19, -120));
        Assert.True(new Clock(3, 0) == new Clock(-18, -180));
        Assert.True(new Clock(3, 0) == new Clock(0, -1_260));
    }

    [Fact]
    public void Inequality()
    {
        Assert.True(new Clock(3, 0) != -new Clock(3, 0));
        Assert.True(new Clock(3, 0) != -new Clock(2, 60));
        Assert.True(new Clock(3, 0) != -new Clock(1, 120));
        Assert.True(new Clock(3, 0) != -new Clock(0, 180));
        Assert.True(new Clock(3, 0) != new Clock(-3, 0));
        Assert.True(new Clock(3, 0) != new Clock(-2, -60));
        Assert.True(new Clock(3, 0) != new Clock(-1, -120));
        Assert.True(new Clock(3, 0) != new Clock(0, -180));
    }

    [Fact]
    public void GreaterThan()
    {
        Assert.True(new Clock(3, 0) > -new Clock(22, 0));
        Assert.True(new Clock(3, 0) > -new Clock(22, 59));
        Assert.True(new Clock(3, 0) > -new Clock(22, 01));
        Assert.True(new Clock(3, 0) > -new Clock(23, 0));
        Assert.True(new Clock(3, 0) > -new Clock(23, 59));
        Assert.True(new Clock(3, 0) > -new Clock(23, 01));
        Assert.True(new Clock(3, 0) > -new Clock(24, 0));
        Assert.True(new Clock(3, 0) > new Clock(-22, 0));
        Assert.True(new Clock(3, 0) > new Clock(-22, -59));
        Assert.True(new Clock(3, 0) > new Clock(-22, -01));
        Assert.True(new Clock(3, 0) > new Clock(-23, 0));
        Assert.True(new Clock(3, 0) > new Clock(-23, -59));
        Assert.True(new Clock(3, 0) > new Clock(-23, -01));
        Assert.True(new Clock(3, 0) > new Clock(-24, 0));
        Assert.True(new Clock(3, 0) > new Clock(0, -1_261));
        Assert.True(new Clock(3, 0) > new Clock(0, -1_380));
        Assert.True(new Clock(3, 0) > new Clock(0, -1_320));
        Assert.True(new Clock(3, 0) > new Clock(0, -1_410));
        Assert.True(new Clock(3, 0) > new Clock(0, -1_437));
        Assert.True(new Clock(3, 0) > new Clock(0, -1_429));
        Assert.True(new Clock(3, 0) > new Clock(24, 0));
        Assert.True(new Clock(3, 0) > new Clock(48, 0));
        Assert.True(new Clock(3, 0) > new Clock(72, 0));
    }

    [Fact]
    public void LesserThan()
    {
        Assert.True(new Clock(3, 0) < -new Clock(24, 59));
        Assert.True(new Clock(3, 0) < -new Clock(24, 01));
        Assert.True(new Clock(3, 0) < -new Clock(3, 0));
        Assert.True(new Clock(3, 0) < -new Clock(2, 60));
        Assert.True(new Clock(3, 0) < -new Clock(1, 120));
        Assert.True(new Clock(3, 0) < -new Clock(0, 180));
        Assert.True(new Clock(3, 0) < new Clock(-24, -59));
        Assert.True(new Clock(3, 0) < new Clock(-24, -01));
        Assert.True(new Clock(3, 0) < new Clock(-3, 0));
        Assert.True(new Clock(3, 0) < new Clock(-2, -60));
        Assert.True(new Clock(3, 0) < new Clock(-1, -120));
        Assert.True(new Clock(3, 0) < new Clock(0, -180));
    }

    [Fact]
    public void GreaterThanOrEquals()
    {
        Assert.True(new Clock(3, 0) >= -new Clock(22, 0));
        Assert.True(new Clock(3, 0) >= -new Clock(22, 59));
        Assert.True(new Clock(3, 0) >= -new Clock(22, 01));
        Assert.True(new Clock(3, 0) >= -new Clock(23, 0));
        Assert.True(new Clock(3, 0) >= -new Clock(23, 59));
        Assert.True(new Clock(3, 0) >= -new Clock(23, 01));
        Assert.True(new Clock(3, 0) >= -new Clock(24, 0));
        Assert.True(new Clock(3, 0) >= new Clock(-22, 0));
        Assert.True(new Clock(3, 0) >= new Clock(-22, -59));
        Assert.True(new Clock(3, 0) >= new Clock(-22, -01));
        Assert.True(new Clock(3, 0) >= new Clock(-23, 0));
        Assert.True(new Clock(3, 0) >= new Clock(-23, -59));
        Assert.True(new Clock(3, 0) >= new Clock(-23, -01));
        Assert.True(new Clock(3, 0) >= new Clock(-24, 0));
        Assert.True(new Clock(3, 0) >= new Clock(0, -1_261));
        Assert.True(new Clock(3, 0) >= new Clock(0, -1_380));
        Assert.True(new Clock(3, 0) >= new Clock(0, -1_320));
        Assert.True(new Clock(3, 0) >= new Clock(0, -1_410));
        Assert.True(new Clock(3, 0) >= new Clock(0, -1_437));
        Assert.True(new Clock(3, 0) >= new Clock(0, -1_429));
        Assert.True(new Clock(3, 0) >= new Clock(24, 0));
        Assert.True(new Clock(3, 0) >= new Clock(48, 0));
        Assert.True(new Clock(3, 0) >= new Clock(72, 0));

        Assert.True(new Clock(3, 0) >= new Clock(3, 0));
        Assert.True(new Clock(3, 0) >= new Clock(2, 60));
        Assert.True(new Clock(3, 0) >= new Clock(1, 120));
        Assert.True(new Clock(3, 0) >= new Clock(0, 180));
        Assert.True(new Clock(3, 0) >= new Clock(75, 0));
        Assert.True(new Clock(3, 0) >= new Clock(51, 0));
        Assert.True(new Clock(3, 0) >= new Clock(27, 0));
        Assert.True(new Clock(3, 0) >= new Clock(26, 60));
        Assert.True(new Clock(3, 0) >= new Clock(25, 120));
        Assert.True(new Clock(3, 0) >= new Clock(24, 180));
        Assert.True(new Clock(3, 0) >= -new Clock(21, 0));
        Assert.True(new Clock(3, 0) >= -new Clock(20, 60));
        Assert.True(new Clock(3, 0) >= -new Clock(19, 120));
        Assert.True(new Clock(3, 0) >= -new Clock(18, 180));
        Assert.True(new Clock(3, 0) >= -new Clock(0, 1_260));
        Assert.True(new Clock(3, 0) >= new Clock(-21, 0));
        Assert.True(new Clock(3, 0) >= new Clock(-20, -60));
        Assert.True(new Clock(3, 0) >= new Clock(-19, -120));
        Assert.True(new Clock(3, 0) >= new Clock(-18, -180));
        Assert.True(new Clock(3, 0) >= new Clock(0, -1_260));
    }

    [Fact]
    public void LesserThanOrEquals()
    {
        Assert.True(new Clock(3, 0) <= -new Clock(24, 59));
        Assert.True(new Clock(3, 0) <= -new Clock(24, 01));
        Assert.True(new Clock(3, 0) <= -new Clock(3, 0));
        Assert.True(new Clock(3, 0) <= -new Clock(2, 60));
        Assert.True(new Clock(3, 0) <= -new Clock(1, 120));
        Assert.True(new Clock(3, 0) <= -new Clock(0, 180));
        Assert.True(new Clock(3, 0) <= new Clock(-24, -59));
        Assert.True(new Clock(3, 0) <= new Clock(-24, -01));
        Assert.True(new Clock(3, 0) <= new Clock(-3, 0));
        Assert.True(new Clock(3, 0) <= new Clock(-2, -60));
        Assert.True(new Clock(3, 0) <= new Clock(-1, -120));
        Assert.True(new Clock(3, 0) <= new Clock(0, -180));

        Assert.True(new Clock(3, 0) <= new Clock(3, 0));
        Assert.True(new Clock(3, 0) <= new Clock(2, 60));
        Assert.True(new Clock(3, 0) <= new Clock(1, 120));
        Assert.True(new Clock(3, 0) <= new Clock(0, 180));
        Assert.True(new Clock(3, 0) <= new Clock(75, 0));
        Assert.True(new Clock(3, 0) <= new Clock(51, 0));
        Assert.True(new Clock(3, 0) <= new Clock(27, 0));
        Assert.True(new Clock(3, 0) <= new Clock(26, 60));
        Assert.True(new Clock(3, 0) <= new Clock(25, 120));
        Assert.True(new Clock(3, 0) <= new Clock(24, 180));
        Assert.True(new Clock(3, 0) <= -new Clock(21, 0));
        Assert.True(new Clock(3, 0) <= -new Clock(20, 60));
        Assert.True(new Clock(3, 0) <= -new Clock(19, 120));
        Assert.True(new Clock(3, 0) <= -new Clock(18, 180));
        Assert.True(new Clock(3, 0) <= -new Clock(0, 1_260));
        Assert.True(new Clock(3, 0) <= new Clock(-21, 0));
        Assert.True(new Clock(3, 0) <= new Clock(-20, -60));
        Assert.True(new Clock(3, 0) <= new Clock(-19, -120));
        Assert.True(new Clock(3, 0) <= new Clock(-18, -180));
        Assert.True(new Clock(3, 0) <= new Clock(0, -1_260));
    }
}
