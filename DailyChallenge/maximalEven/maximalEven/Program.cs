using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximalEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 7, 2};
            maximalEven(inputArray);
        }

        static int maximalEven(int[] inputArray)
        {
            int maxVal = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if(inputArray[i] % 2 == 0)
                {
                    if(inputArray[i] > maxVal)
                    {
                        maxVal = inputArray[i];
                    }
                }
            }
            Console.WriteLine("maxVal: " + maxVal);
            return maxVal;
        }

    }
}
