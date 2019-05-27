using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayMaximalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 19, 32, 11, 23 };
            int result = arrayMaximalDifference(inputArray);
            Console.WriteLine("result: " + result);
        }

        static int arrayMaximalDifference(int[] inputArray)
        {
            int maxValue = inputArray[0];
            int maxDiff = 0;
            for (int j = 0; j < inputArray.Length; j++)
            {
                //Console.WriteLine("inputARray[j] : " + inputArray[j]);
                for (int i = j + 1; i < inputArray.Length; i++)
                {
                    //Console.WriteLine("inputARray[i] : " + inputArray[i]);
                    //Console.WriteLine("maxValue " + maxValue);
                    maxDiff = Math.Abs(inputArray[j] - inputArray[i]);
                    //Console.WriteLine("maxDiff " + maxDiff);
                    if (maxValue < maxDiff)
                    {
                        maxValue = maxDiff;
                    }

                }
                
            }

            return maxValue;
        }

    }
}
