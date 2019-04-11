using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 10, 20, 30, 40 };
            int value = 42;
            bool result = sumOfTwo(a, b, value);
            Console.WriteLine(result);

        }

        public static bool sumOfTwo(int[] a, int[] b, int v)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    if(a[i] + b[j] == v)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
