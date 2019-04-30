using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisor = 9;
            int bound = 60;
            int result = maxMultiple(divisor, bound);
            Console.WriteLine("result: " + result);

        }
        /*
         * Given a divisor and a bound, find the largest integer N such that:

           * N is divisible by divisor.
           * N is less than or equal to bound.
           * N is greater than 0
         */
        static int maxMultiple(int divisor, int bound)
        {
            int maxMultipleNumber = (bound / divisor) * divisor;           
            return maxMultipleNumber;
        }

    }
}
