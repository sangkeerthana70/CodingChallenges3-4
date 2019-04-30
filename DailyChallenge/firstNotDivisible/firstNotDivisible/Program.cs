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
            int[] divisors = { 3 };
            int start = 123;
            int result = firstNotDivisible(divisors, start);
            Console.WriteLine("result: " + result);
        }
        static int firstNotDivisible(int[] divisors, int start)
        {
            int numNotDivisible = 0;
            for(int i = 0; i < divisors.Length; i++)
            {
                if(start % divisors[i] != 0)
                {
                    //Console.WriteLine("mod result: " + start % divisors[i]);
                    numNotDivisible = start;
                    return numNotDivisible;
                }
                start++;
            }
            return start;
        }

    }
}
