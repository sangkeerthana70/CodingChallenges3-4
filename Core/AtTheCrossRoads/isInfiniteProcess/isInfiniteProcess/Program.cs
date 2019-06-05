using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isInfiniteProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 10;
            bool result = isInfiniteProcess(a, b);
            Console.WriteLine("result " + result);


        }
        /*
         Given integers a and b, determine whether the following pseudocode
         results in an infinite loop
        */

        static bool isInfiniteProcess(int a, int b)
        {

            if (a > b)
            {
                return true;
            }
            if (a == b)
            {
                return false;
            }

            if (b > a)
            {
                if ((b - a) % 2 == 0)
                {
                    return false;
                }

            }

            return true;

        }
    }
}
