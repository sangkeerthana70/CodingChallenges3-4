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
            bool res;
            char[] arr = inputString.ToCharArray();
            foreach(char item in arr)
            {
                Console.WriteLine("char: " + item);
            }

            Console.WriteLine();
             Array.Reverse(arr);
            foreach (char reverse in arr)
            {
                Console.WriteLine("reverse: " + reverse);
            }
            string s1 = String.Join(" ", arr);
            Console.WriteLine("s1: " + s1);

            Console.WriteLine(String.Equals(inputString, s1));
            /*
            if (myOutput == 0)
            {
                //Console.WriteLine(inputString.Equals(s1));
                res = true;
                
            }
            else
            {
                Console.WriteLine("In else");
                Console.WriteLine(inputString.Equals(s1));
                res = false;
            }*/
            
            return String.Equals(inputString, s1);
        }

    }
}
