using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 25;
            bool result = checkFactorial(n);
            Console.WriteLine("result: " + result);          
        }

        /*
         * Given an integer n, check if n = k! for some non-negative integer k.
           For n = 120, the output should be checkFactorial(n) = true.
           Here 120 = 5!.
           For n = 25, the output should be
           checkFactorial(n) = false.
           Here 4! = 24 < 25 < 120 = 5!.*/



        static bool checkFactorial(int n)
        {
            int k = 1;
            while (true)
            {
                Console.WriteLine("result " + Factorial(k));
                if (Factorial(k) == n)
                {
                    return true;
                }

                if (Factorial(k) > n)
                {
                    return false;
                }
                k++;
            }
            
        }
        static int Factorial(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return (i * Factorial(i - 1));

            }
            
        }



    }
}
