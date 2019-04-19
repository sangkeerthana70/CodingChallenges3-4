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
            int[] arr = new int[] { 3, -7, 0 };
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
                Console.WriteLine("i is: " + i);
                Console.WriteLine("arr[i]: " + arr[i]);
                for (int j = i+1; j < arr.Length; j++)
                {
                    Console.WriteLine("arr[j] : " + arr[j]);
                    diffOfAdjacentElements = Math.Abs(arr[i] - arr[j]);
                    Console.WriteLine("Diff: " + diffOfAdjacentElements);
                }
                if (diffOfAdjacentElements < minimDifferenece)
                {
                    minimDifferenece = diffOfAdjacentElements;
                    Console.WriteLine("min diff: " + minimDifferenece);
                }
            }
            return minimDifferenece;

        }

    }
}
