using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortByLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string []inputArray = {"abc",
              "",
              "aaa",
              "a",
              "zz" };
            string[] result = sortByLength(inputArray);
            Console.WriteLine(String.Join(",", result));
        }
        /*
        Given an array of strings, sort them in the order of increasing lengths.
        If two strings have the same length, their relative order must be the same
        as in the initial array.
        */

        static string[] sortByLength(string[] inputArray)
        {
            Console.WriteLine(String.Join(",", inputArray));

            for (int j = 0; j < inputArray.Length; j++)
            {
                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    if (inputArray[i].Length > inputArray[i + 1].Length)
                    {                      
                        string temp = inputArray[i];
                        inputArray[i] = inputArray[i + 1];
                        inputArray[i + 1] = temp;
                    }
                    
                }
                
            }
            //Console.WriteLine(String.Join(",", inputArray));
            return inputArray;
        }

    }
}
