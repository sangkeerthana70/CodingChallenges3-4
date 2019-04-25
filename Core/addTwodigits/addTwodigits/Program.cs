using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addTwodigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 99;
            int result = addTwoDigits(n);
            Console.WriteLine("result: " + result);
        }
        /*
         * You are given a positive two-digit integer n < 99. Return the sum of its digits.
         */

        static int addTwoDigits(int n)
        {

            int lastDigit = n % 10;
            //Console.WriteLine("remainder: " + lastDigit);
            int firstDigit = n / 10;
            //Console.WriteLine("quotient: " + firstDigit);
            return lastDigit + firstDigit;

        }

    }
}
