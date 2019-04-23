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

        static string[] sortByLength(string[] inputArray)
        {
            
           
            for(int j = 0; j < inputArray.Length; j++)
            {
                for (int i = 0; i < inputArray.Length - 1; i++)
                {

                    if (inputArray[i].Length > inputArray[i + 1].Length)
                    {
                        Console.WriteLine("inside if");
                        string temp = inputArray[i];
                        Console.WriteLine("temp: " + temp);
                        inputArray[i] = inputArray[i + 1];
                        Console.WriteLine("inputArray[i] " + inputArray[i]);
                        inputArray[i + 1] = temp;
                        Console.WriteLine("inputArray[i+1] " + inputArray[i + 1]);

                    }
                    
                }
                Console.WriteLine(String.Join(",", inputArray));
            }
            
           
            

            return inputArray;
        }

    }
}
