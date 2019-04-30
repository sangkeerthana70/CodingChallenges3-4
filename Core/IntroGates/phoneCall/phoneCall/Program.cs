using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneCall
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 20;
            int min1 = 3;
            int min2_10 = 1;
            int min11 = 2;
            int result = phoneCall(min1, min2_10, min11, s);
            Console.WriteLine("result: " + result);
        }

        static int phoneCall(int min1, int min2_10, int min11, int s)
        {

            if (s < min1)
            {
                return 0;
            }

            int runningBalance = s;
            int minutes = 0;

            // first minute
            runningBalance -= min1;
            minutes += 1;

            // 2 to 10 mins
            if (runningBalance >= (min2_10 * 9))
            {
                runningBalance -= (min2_10 * 9);
                minutes += 9;
            }
            else
            {
                minutes += runningBalance / min2_10;
                return minutes;
            }

            // > 10 mins
            minutes += runningBalance / min11;
            return minutes;

           

        }
    }

    
}
