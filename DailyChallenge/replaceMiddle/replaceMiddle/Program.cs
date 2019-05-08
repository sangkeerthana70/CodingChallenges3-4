using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replaceMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 2, 2, 5, 10, 7 };
            replaceMiddle(arr);
        }

        static int[] replaceMiddle(int[] arr)
        {
            int[] replaceMiddleElement = new int[] { };
            float median = 0;
            int arrLength = arr.Length;
            if (arrLength % 2 != 0)
            {
                Console.WriteLine("In If");
                Console.WriteLine(arr.Length % 2);
                median = arr[arrLength / 2];
                Console.WriteLine("median: " + median);
            }
            //if length is even
            else
            {
                Console.WriteLine("in else");
                Console.WriteLine("Middle element1: " + arr[(arrLength / 2) - 1]);
                Console.WriteLine("Middle element2: " + arr[arrLength / 2]);
                //cast integer to float as median is of type float
                median = (float)(arr[arrLength / 2] + arr[(arrLength / 2) - 1]) / 2;
                Console.WriteLine("Median: " + median);
            }
            return replaceMiddleElement;

        }

    }
}
