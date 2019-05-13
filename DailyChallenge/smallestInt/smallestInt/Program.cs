using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallestInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = new int[] { -1, 0, -5 , -10, 5};
            int result = FindSmallestInt(numArr);
            Console.WriteLine("result : " + result);
        } 
        public static int FindSmallestInt(int[] arr)
        {
            int minVal = Int32.MaxValue;
            /*
            for(int index = 0; index < arr.Length; index++)
            {
                Console.WriteLine("i : " + index);
                if(arr[index] < minVal)
                {
                    minVal = arr[index];
                }
            }
            */
            int i = 0;
            foreach(int num in arr)
            {
                if(Math.Abs(num) < Math.Abs(minVal))
                {
                    Console.WriteLine("i :" + i);
                    minVal = num;
                    Console.WriteLine("minVal : " + minVal);
                  
                }
                i++;
            }
            
            
            return minVal;
        }
    }
}
