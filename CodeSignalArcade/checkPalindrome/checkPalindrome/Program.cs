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
            bool result = checkPalindrome(input);
            Console.WriteLine("result: " + result);
        }

        public static bool checkPalindrome(string inputString)
        {
           
            char[] arr = inputString.ToCharArray();
           
            Array.Reverse(arr);
            
            string s1 = String.Join("", arr);
            Console.WriteLine("s1: " + s1);

            Console.WriteLine(String.Equals(inputString, s1));
            Console.WriteLine("s1 = {0}, inputString = {1}",s1,inputString);
            return String.Equals(inputString, s1);
        }

    }
}
