using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 578943;
            int k = 2;
            int result = kthDigit(n, k);
            Console.WriteLine("result: " + result);
        }

        // Given an integer, find its kth digit.

        public static int kthDigit(int n, int k)
        {
            int kDigit = 0;
            char [] number = n.ToString().ToArray();
            for(int i = 0; i < number.Length -1; i++)
            {
                Console.WriteLine("char in array: " + number[i]);
                Console.WriteLine(k-1);
                Console.WriteLine("k - 1: " + number[k-1]);
                if(i == (k - 1))
                {
                    Console.WriteLine("Inside if");
                    number[k - 1].ToString();
                    kDigit = Convert.ToInt32(number[k - 1].ToString());
                    Console.WriteLine("kDigit: " + kDigit);
                }
            }
            return kDigit;

            
        }

    }
}
