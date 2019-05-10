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
            int[] result = replaceMiddle(arr);
            Console.WriteLine("result: " + String.Join(",", result));
        }

        static int[] replaceMiddle(int[] arr)
        {
            List<int> replaceMiddleElement = new List<int>(arr);
            Console.WriteLine("ArrToList: " + String.Join(",", replaceMiddleElement));
            float median = 0;
            int arrLength = replaceMiddleElement.Count;
            
           
            if (arrLength % 2 != 0)
            {
                Console.WriteLine("In If");
                Console.WriteLine(arr.Length % 2);
                median = replaceMiddleElement[arrLength / 2];
                Console.WriteLine("median: " + median);
            }
            //if length is even
            else
            {
                Console.WriteLine("in else");
                Console.WriteLine("Middle element1: " + replaceMiddleElement[(arrLength / 2) - 1]);
                Console.WriteLine("Middle element2: " + replaceMiddleElement[arrLength / 2]);
                //cast integer to float as median is of type float
                median = (float)(replaceMiddleElement[arrLength / 2] + replaceMiddleElement[(arrLength / 2) - 1]) / 2;
                Console.WriteLine("Median: " + median);
                Console.WriteLine("ArrToList: " + String.Join(",", replaceMiddleElement));
                replaceMiddleElement[(arrLength / 2) - 1] = replaceMiddleElement[(arrLength / 2) - 1] + replaceMiddleElement[arrLength / 2];
                Console.WriteLine("ArrToList: " + String.Join(",", replaceMiddleElement));
                replaceMiddleElement.RemoveAt(arrLength / 2);
                Console.WriteLine("ArrToList: " + String.Join(",", replaceMiddleElement));

            }
            return replaceMiddleElement.ToArray();

        }

    }
}
