using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumAbsoluteDiffrenceInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -59, -36, -13, 1, -53, -92, -2, -96, -54, 75 };
            //int[] arr = new int[] { 1,- 3, 71, 68, 17 };
            //int[] arr = new int[] { 3, -7, 0 };
            int result = minimumAbsoluteDifference(arr);
            Console.WriteLine("result: " + result);
        }

        // Complete the minimumAbsoluteDifference function below.
        static int minimumAbsoluteDifference(int[] arr)
        {
            int minimDifferenece = int.MaxValue;
            int diffOfAdjacentElements = 0;
            for (int i = 0; i < arr.Length -1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    diffOfAdjacentElements = Math.Abs(arr[i] - arr[j]);
                    if (diffOfAdjacentElements < minimDifferenece)
                    {
                        minimDifferenece = diffOfAdjacentElements;
                    }
                }
            }
            return minimDifferenece;
        }

    }
}
