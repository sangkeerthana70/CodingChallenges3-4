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
            //int[] arr = new int[] { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            //int[] brr = new int[] { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] arr = new int[] { 11, 4, 11, 7, 13, 4, 12, 11, 10, 14 };
            int[] brr = new int[] { 11, 4, 11, 7, 3, 7, 10, 13, 4, 8, 12, 11, 10, 14, 12 };
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

            //foreach (var pair in lostList)
            //{
            //    Console.WriteLine("lostList key = {0} value = {1}", pair.Key, pair.Value);
            //}

            for (int j = 0; j < brr.Length; j++)
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

            //foreach (var pair in originalList)
            //{
            //    Console.WriteLine("originalList key = {0} value = {1}", pair.Key, pair.Value);
            //}


            if (originalList.Count == lostList.Count)
            {
                //Console.WriteLine("inside if - dictionaries count match");
               
               foreach(var item in lostList)
               {
                    //compare both dictionaries's value
                    lostList.TryGetValue(item.Key, out int value);                  
                    originalList.TryGetValue(item.Key, out int value2);
 
                    int valueDifference = value2 - value;
 
                    if(valueDifference >= 1)
                    {
                        result.Add(item.Key);
                    }

                }
            }
            else
            {
                //Console.WriteLine("inside else - dictionaries count not match");
               
                foreach (KeyValuePair<int, int> item in originalList)
                {                   
                    //Console.WriteLine(lostList.ContainsKey(item.Key));
                    if (!lostList.ContainsKey(item.Key))
                    {
                        lostList.ContainsValue(item.Value);
                        result.Add(item.Key);
                    }
                    else
                    {
                        //compare both dictionaries's value
                        lostList.TryGetValue(item.Key, out int value);
 
                        originalList.TryGetValue(item.Key, out int value2);
  
                        int valueDifference = value2 - value;

                        if (valueDifference >= 1)
                        {
                            result.Add(item.Key);
                        }
                    }
                }
            }
            
            result.Sort();
            return result.ToArray();
        }
    }
}
