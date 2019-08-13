using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isCaseInsensitivePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "AaBaa";
            bool result = isCaseInsensitivePalindrome(input);
            Console.WriteLine("result " + result);
        }

        static bool isCaseInsensitivePalindrome(string inputString)
        {
            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(String.Join(",", arr));

            string reverse = new string(arr);
            Console.WriteLine("reverse " + reverse);
           

            if(inputString == reverse)
            {
                return true;
            }

            if(inputString.ToUpper() == reverse.ToUpper())
            {
                Console.WriteLine("in upper");
                return true;
            }

            if (inputString.ToLower() == reverse.ToLower())
            {
                Console.WriteLine("in lower");
                return true;
            }

            return false;
        }

    }
}
