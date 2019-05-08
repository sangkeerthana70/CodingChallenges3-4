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
            int val = 0;
            int result = FindIndexOfVal(arr, val);
            Console.WriteLine("result: " + result);
        }
        static int FindIndexOfVal(int[] arr, int val)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
