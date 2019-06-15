using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 2, 5, 3, 5, 3 };
            int[] brr = new int[] { 7, 2, 5, 4, 6, 3, 5, 3 };
            missingNumbers(arr, brr);
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {

            Dictionary<int, int> lostList = new Dictionary<int, int>();
            Dictionary<int, int> originalList = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if (lostList.ContainsKey(arr[i]))
                {
                    lostList[arr[i]] += 1;
                }
                else
                {
                    lostList.Add(arr[i], 1);
                }
            }

            foreach (var pair in lostList)
            {
                Console.WriteLine("key = {0} value = {1}", pair.Key, pair.Value);
            }
        }
    }
}
