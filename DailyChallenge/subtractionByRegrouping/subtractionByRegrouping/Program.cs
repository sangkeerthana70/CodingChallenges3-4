using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtractionByRegrouping
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuend = 2024;
            int subtrahend = 1234;
            subtractionByRegrouping(minuend, subtrahend);
        }

        static int[] subtractionByRegrouping(int minuend, int subtrahend)
        {

            int[] numbersSubtracted = new int[] { };
            int mod = minuend % 10;
            Console.WriteLine("mod : " + mod);
            int rem = minuend / 10;
            Console.WriteLine("rem: " + rem);
            return numbersSubtracted;

        }

    }
}
