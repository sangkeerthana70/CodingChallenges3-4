using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_sTotientFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int result = eulersTotientFunction(n);
            Console.WriteLine("result " + result);

        }

        static int eulersTotientFunction(int n)
        {
            int result = 0;

            //get all factors of n
            List<int> b = new List<int>();
            b = findFactors(n);
            Console.WriteLine("b " + String.Join(",", b));

           // List<int> common = new List<int> ();

            List<int> a = new List<int> ();

            for(int i = 2; i < n; i++)
            {
                // get factors of each element from 2 to n
                a = findFactors(i);
                Console.WriteLine("a " + String.Join(",", a));

                //compare list a with list b
                var common = a.Intersect(b);
                Console.WriteLine("common.Count " + common.Count());
                // if there is no common factor for n and any element between 2 and 4 increment the result and add one to it as loop starts at 2
                if(common.Count() == 0)
                {
                    result++;
                }

            }

            return result +1;
           



        }

        static List<int> findFactors(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }
            }

            return factors;
        }
    }
}
