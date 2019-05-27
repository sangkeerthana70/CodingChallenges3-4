using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] divisors = { 5, 7, 11};
            int start = 386;
            int result = firstMultiple(divisors, start);
            Console.WriteLine("result " + result);

        }

        /*
         
        Find the smallest integer not less than the given limit which is divisible by all integers from the given array.

        Example

        For divisors = [2, 3, 4] and start = 13, the output should be
        firstMultiple(divisors, start) = 24.
        */

        static int firstMultiple(int[] divisors, int start)
        {
           
            Console.WriteLine("start: " + start);

            while (true)
            {
                bool divisible = true;
                for (int i = 0; i < divisors.Length; i++)
                {
                    //Console.WriteLine("i is " + i);
                    //Console.WriteLine("in for loop");
                    
                    //Console.WriteLine("divisors[i] " + divisors[i]);
                    //Console.WriteLine("start in loop: " + start);
                    //Console.WriteLine("start % divisors[i] " + start % divisors[i]);
                    if ( start % divisors[i] != 0)
                    {
                        divisible = false;
                        continue;
                    }

                }
                if(divisible == true)
                {
                    return start;
                }
                start++;

            }
           

            return start;
        }
        

    }
}
