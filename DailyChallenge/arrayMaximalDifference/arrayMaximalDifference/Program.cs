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

        /*
           Given an array of integers, find the maximal difference(difference of minimum and
           maximum values in the array) among all possible pairs of its elements.
          */

        static int arrayMaximalDifference(int[] inputArray)
        {
            int maxValue = Int32.MinValue;
            int minValue = Int32.MaxValue;


            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > maxValue)
                {
                    maxValue = inputArray[i];
                }
                if (inputArray[i] < minValue)
                {
                    minValue = inputArray[i];
                }

            }

            return maxValue - minValue;




            return maxValue;
        }

    }
}
