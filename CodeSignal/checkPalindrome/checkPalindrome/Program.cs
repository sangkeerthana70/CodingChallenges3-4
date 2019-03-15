using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "aabaa";
        }

        public static bool checkPalindrome(string inputString)
        {

            char[] arr = inputString.ToCharArray();
            foreach(char item in arr)
            {
                Console.WriteLine("char: " + item);
            }
            Array.Reverse(arr);

            //return new string(arr);
            return true;
        }

    }
}
