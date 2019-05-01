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
        static int firstNotDivisible(int[] divisors, int start)
        {
            
           while(start <= 150)
           {
                Console.WriteLine("start: " + start);
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
