using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIndexOfFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 25, 21, 3, 25, 7 };
            int val = 21;
            int val2 = 7;
            int result = FindIndexOfVal(arr, val);
            Console.WriteLine("result: " + result);
            int result2 = FindLastIndexOfVal(arr, val2);
            Console.WriteLine("result2: " + result2);
        }
        static int FindIndexOfVal(int[] arr, int val)
        {
            bool foundIndex = false;
            int i = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if(arr[i] == val)
                {
                    foundIndex = true;
                    break;
                }
            }
            if(foundIndex == true)
            {
                return i;
            }
            else
                 return -1;
        }

        static int FindLastIndexOfVal(int [] arr, int val)
        {
            int i = 0;
            int tempi = -1;
            for(i = 0; i < arr.Length; i++)
            {
                if(arr[i] == val)
                {
                    tempi = i;
                }
            }
            return tempi;
        }

    }
}
