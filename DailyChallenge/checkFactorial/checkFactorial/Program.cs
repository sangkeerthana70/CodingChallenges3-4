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
            int n = 120;
            bool result = checkFactorial(n);
            Console.WriteLine("result: " + result);
            //int fact = Factorial(n);
            //Console.WriteLine("fact " + fact);
           
        }
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
