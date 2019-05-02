using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstNotDivisible
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] divisors = { 2, 3, 4 };
            int start = 14;
            int result = firstNotDivisible(divisors, start);
            Console.WriteLine("result: " + result);
        }

        /*
         * Find the smallest integer not less than the given limit which is not divisible
         * by any of the integers from the given array.

        Example

        For divisors = [2, 3, 4] and start = 14, the output should be
        firstNotDivisible(divisors, start) = 17.
        */
        static int firstNotDivisible(int[] divisors, int start)
        {
            
           while(start <= 150)
           {
                //Console.WriteLine("start: " + start);
                bool divisible = false;
                for (int i = 0; i < divisors.Length; i++)
                {
                    if (start % divisors[i] == 0)
                    {
                        divisible = true;
                        continue;
                    }
                }
                if (divisible == false)
                {
                    return start;
                }
                start++; 
           }
            return start;
        }
    }    
}
