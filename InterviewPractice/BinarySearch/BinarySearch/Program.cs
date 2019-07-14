using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // arr will have 100 unique elements with values in range 0 to 1000
            var arr = Enumerable.Range(0, 10000).OrderBy(x => random.Next()).Take(1000).ToArray();

            Array.Sort(arr);

            //// for display only
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("i = {0};  arr[i] = {1}",i, arr[i]);
            //}

            int expected = random.Next(1000);
            Console.WriteLine("Array Size: " + arr.Length);
            Console.WriteLine("Searching for element {0} at index {1}...", arr[expected],expected);
            int actual = LinearSearch(arr, arr[expected]);
        }



        private static int LinearSearch(int[] arr, int searchElement)
        {
            int i = 0;
            for(i = 0; i < arr.Length; i++)
            {
                if(arr[i] == searchElement)
                {
                    Console.WriteLine("Answer = {0}; Loop Count = {1}", i, i);
                    return i;
                }
                
            }
            Console.WriteLine("Answer = {0}; Loop Count = {1}", -1, i);
            return -1;
            
        }

        private static int MyBinarySearch(int[] arr, int searchNum)
        {
           

            return 0;
        }
    }
}
