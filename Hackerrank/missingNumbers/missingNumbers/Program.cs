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
            int [] result = missingNumbers(arr, brr);
            Console.WriteLine("result: " + String.Join(",", result));
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            List<int> result = new List<int>();

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
                Console.WriteLine("lostList key = {0} value = {1}", pair.Key, pair.Value);
            }

            for(int j = 0; j < brr.Length; j++)
            {
                if (originalList.ContainsKey(brr[j]))
                {
                    originalList[brr[j]] += 1;
                }
                else
                {
                    originalList.Add(brr[j], 1);
                }
            }

            foreach (var pair in originalList)
            {
                Console.WriteLine("originalList key = {0} value = {1}", pair.Key, pair.Value);
            }

            bool equal = false;
            if (originalList.Count == lostList.Count)
            {
                Console.WriteLine("inside comparing dictionaries count");
                
            }
            else
            {
                equal = true;
                int diff;
                
                foreach (KeyValuePair<int, int> item in originalList)
                {
                    
                    // Console.WriteLine("inside compare dicts");
                    //originalList.TryGetValue(item.Key, out int value);
                    // Console.WriteLine("value of item.Key: " + value + " " + item.Key);
                    Console.WriteLine("=========================================================================");

                    Console.WriteLine(lostList.ContainsKey(item.Key));
                    if (!(lostList.ContainsKey(item.Key)))
                    {
                        Console.WriteLine("inside lostList");
                        lostList.ContainsValue(item.Value);
                        Console.WriteLine("lostList value:" + lostList.ContainsValue(item.Value) + " " +  item.Key);
                        result.Add(item.Key);
                       
                    }

                }
            }


            return result.ToArray();
        }
    }
}
