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
            
           
            if (arrLength % 2 != 0)
            {
                return arrToList.ToArray();
            }
            //if length is even
            else
            {
           
                //Console.WriteLine("Middle element1: " + arrToList[(arrLength / 2) - 1]);
                //Console.WriteLine("Middle element2: " + arrToList[arrLength / 2]);
                
                //Console.WriteLine("ArrToList: " + String.Join(",", arrToList));
                arrToList[(arrLength / 2) - 1] = arrToList[(arrLength / 2) - 1] + arrToList[arrLength / 2];
                //Console.WriteLine("ArrToList: " + String.Join(",", arrToList));
                arrToList.RemoveAt(arrLength / 2);
                //Console.WriteLine("ArrToList: " + String.Join(",", arrToList));

            }
            return arrToList.ToArray();

        }

    }
}
