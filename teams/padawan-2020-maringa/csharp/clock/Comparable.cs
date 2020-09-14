using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Clock
{
    public class Comparable : IComparable<Clock>, IComparer<Clock>
    {
        public int Compare([AllowNull] Clock x, [AllowNull] Clock y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo([AllowNull] Clock other)
        {
            if (base.Equals(other))
            {
                return 0;
            }
            if(base.Hours)
        }
    }
}
