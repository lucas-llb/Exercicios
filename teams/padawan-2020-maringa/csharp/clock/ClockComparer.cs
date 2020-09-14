using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

    static class ClockComparer
    {
        public static Ascending Ascending => new Ascending();
        public static Descending Descending => new Descending();
        public static DescendingHourAscendingMinutes DescendingHourAscendingMinutes => new DescendingHourAscendingMinutes();
    }
    class Ascending : IComparer<Clock>
    {
        public int Compare([AllowNull] Clock x, [AllowNull] Clock y)
        {
            if(x.ToMinutes() > y.ToMinutes())
            {
                return 1;
            }
            if(x.ToMinutes() < y.ToMinutes())
            {
                return -1;
            }
            else
            return 0;
        }
    }
    class Descending : IComparer<Clock>
    {
        public int Compare([AllowNull] Clock x, [AllowNull] Clock y)
        {
        if (x.ToMinutes() > y.ToMinutes())
        {
            return -1;
        }
        if (x.ToMinutes() < y.ToMinutes())
        {
            return 1;
        }
        else
            return 0;
    }
    }
    class DescendingHourAscendingMinutes : IComparer<Clock>
    {
        public int Compare([AllowNull] Clock x, [AllowNull] Clock y)
        {
            throw new NotImplementedException();
        }
    }

