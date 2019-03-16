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
            int num = 21445;

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
                while(num > 0)
                {                                     
                    reverse = (reverse * 10) + num % 10;                   
                    num = num / 10;
                }                
                return reverse;
            }
        }
    }
}
