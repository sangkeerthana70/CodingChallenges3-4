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
            int[] divisors = { 2, 3, 4 };
            int start = 13;
            int result = firstMultiple(divisors, start);
            Console.WriteLine("result " + result);

        }

        static int firstMultiple(int[] divisors, int start)
        {
           
            Console.WriteLine("start: " + start);

            while (start <= 400)
            {
                bool divisible = true;
                for (int i = 0; i < divisors.Length; i++)
                {
                    Console.WriteLine("i is " + i);
                    Console.WriteLine("in for loop");
                    
                    Console.WriteLine("divisors[i] " + divisors[i]);
                    Console.WriteLine("start in loop: " + start);
                    Console.WriteLine("start % divisors[i] " + start % divisors[i]);
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
