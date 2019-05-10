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
            List<int> arrToList = new List<int>(arr);
            Console.WriteLine("ArrToList: " + String.Join(",", arrToList));
            
            int arrLength = arrToList.Count;
            
           // if length is odd
            if (arrLength % 2 != 0)
            {
                return arrToList.ToArray();
            }
            //if length is even
            else
            {
                arrToList[(arrLength / 2) - 1] = arrToList[(arrLength / 2) - 1] + arrToList[arrLength / 2];               
                arrToList.RemoveAt(arrLength / 2);
            }
            return arrToList.ToArray();
        }

    }
}
