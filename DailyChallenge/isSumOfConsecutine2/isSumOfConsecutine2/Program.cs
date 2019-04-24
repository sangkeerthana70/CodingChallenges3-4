using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isSumOfConsecutine2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 25;
            int result = isSumOfConsecutive2(n);
            Console.WriteLine("result: " + result);
        }
        /*
         * Find the number of ways to express n as sum of some (at least two) 
         * consecutive positive integers.
        */

        static int isSumOfConsecutive2(int n)
        {

            int combination = 0;
            for (int i = 1; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += j;
                    if (sum == n)
                    {
                        
                        combination += 1;
                    }
                    if (sum > n)
                    {
                        break;
                    }
                }
            }
            return combination;
        }
    }
}
