using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 214;

            int res = Kata.ReversedOrder(num);
            Console.WriteLine(res);
        }


        // create a fuction that will take an integer and reverse the order

        // ex
        // Input: 21445 Output: 54412

        // Input: 145263 Output: 362541

        // Input: 1254859723 Output: 3279584521

        public static class Kata
        {
            public static int ReversedOrder(int num)
            {
                int reverse = 0;
                int i = 1;
                while(num > 0)
                {
                    Console.WriteLine("loop: " + i);
                    int lastDigit = num % 10;
                    Console.WriteLine("lastDigit: " + lastDigit);
                    Console.WriteLine("reverse * 10: " + reverse * 10);
                    reverse = (reverse * 10) + lastDigit;
                    Console.WriteLine("reverse: " + reverse);
                    num = num / 10;
                    Console.WriteLine("num: " + num);
                    i++;
                }
                Console.WriteLine("reverse: " + reverse);
                return reverse;
            }
        }
    }
}
