using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace improperFractionToMixed
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 2 };
            int [] result = improperFractionToMixed(a);
            Console.WriteLine(String.Join(",", result));
        }
        static int[] improperFractionToMixed(int[] a)
        {
            List<int> mixedFraction = new List<int>();
            for (int i = 0; i < a.Length -1; i++)
            {
                int quotient  = a[i] / a[i + 1];
                Console.WriteLine(quotient);
                mixedFraction.Add(quotient);
                int remainder = a[i] % a[i + 1];
                Console.WriteLine(remainder);
                mixedFraction.Add(remainder);
                mixedFraction.Add(a[i + 1]);

            }
            return mixedFraction.ToArray();
        }

    }
}
