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
            int n = 5;
            int result = eulersTotientFunction(n);

        }

        static int eulersTotientFunction(int n)
        {


        }

        static int[] findFactors(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }
            }

            return factors.ToArray();
        }
    }
}
