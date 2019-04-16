using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centuryFromYear
{
    public static class CheckRange
    {
        public static bool InRange(this int value, int from, int to)
        {
            if (value >= from && value <= to)
                return true;
            return false;
        }

        
    }
}
