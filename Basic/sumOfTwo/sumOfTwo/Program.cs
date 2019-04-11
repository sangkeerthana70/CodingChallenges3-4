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
            int value = 50;
            bool result = sumOfTwo(a, b, value);
            Console.WriteLine(result);

        }

        public static bool sumOfTwo(int[] a, int[] b, int v)
        {
            int len = a.Length;
            Console.WriteLine(len);
            int len1 = b.Length;
            Console.WriteLine(len1);
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    Console.WriteLine("i: " + i);
                    Console.WriteLine("a[i] " + a[i]);
                    Console.WriteLine("b[j] " + b[j]);
                    Console.WriteLine();
                    if (a[i] + b[j] == v)
                    {
                        // Console.WriteLine("a[i] " + a[i]);
                        //Console.WriteLine("b[j] " + b[j]);
                        return true;
                    }
                }
            }

            return false;
            return false;
        }

    }
}
