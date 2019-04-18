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
            int n = 786543;
            int k = 2;
            int result = kthDigit(n, k);            
        }

        // Given an integer, find its kth digit.

        public static int kthDigit(int n, int k)
        {
            string input = n.ToString();            
            string result = input.Substring(k - 1, 1);
            int kDigit = Convert.ToInt32(result);
            //Console.WriteLine("kDigit: " + kDigit);
            return kDigit;

        }

    }
}
