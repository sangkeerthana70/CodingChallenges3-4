using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 2, 1, 3, 5, 3, 2 };
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = firstDuplicate(arr);
        }

        static int firstDuplicate(int[] a)
        {
            
            Dictionary<int, int> duplicates = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                // for second occurance add i's value and this condition will not add the third occcurance 
                if (duplicates.ContainsKey(a[i]) && duplicates[a[i]] == -1)
                {
                    
                    duplicates[a[i]] = i;
                }
                else
                {
                    // set the value as -1 for first occurance
                    duplicates.Add(a[i], -1);
                }
            }

            int minValue = Int32.MaxValue;
            int minKey = -1;
            foreach (KeyValuePair<int, int> num in duplicates)
            {
                Console.WriteLine("Key: {0}, Value: {1}", num.Key, num.Value);
                duplicates.TryGetValue(num.Key, out int value);

                if (value != -1) 
                {
                    Console.WriteLine("num.Key = {0}, num.Value = {1} ", num.Key, value);
                    if(value < minValue)
                    {
                        minValue = value;
                        minKey = num.Key;
                    }
                    
                }
            }
            Console.WriteLine("minKey " + minKey);
            return minKey; 
        }

    }
}
