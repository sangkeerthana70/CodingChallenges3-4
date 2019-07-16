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
            var arr = Enumerable.Range(0, 10000).OrderBy(x => random.Next()).Take(100).ToArray();

            Array.Sort(arr);

            //// for display only
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("i = {0};  arr[i] = {1}",i, arr[i]);
            //}

            int expected = random.Next(100);
            Console.WriteLine("Array Size: " + arr.Length);
            Console.WriteLine("Searching for element {0} at index {1}...", arr[expected],expected);
            Console.WriteLine("Executing Linear Search");

            int actual = LinearSearch(arr, arr[expected]);

            Console.WriteLine("Executing Binary Search");
            actual = MyBinarySearch(arr, arr[expected]);
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

            int index = arr.Length / 2;
            int i = 0;
            int prevIndex = arr.Length;

            while (true)
            {
                Console.WriteLine("Examining element at index " + index);
                Console.WriteLine("Expected : {0}; Found : {1}",searchNum,arr[index]);
                if (i++ > 100) break;
                Console.WriteLine("Loop Count : " + i);
               
                if(arr[index]  == searchNum)
                {
                    Console.WriteLine("Answer : " + index);
                    return index;
                }

                if ((index == arr.Length) || (index == 0))
                {
                    break;
                }

                if(arr[index] < searchNum)
                {
                    Console.WriteLine("Moving right");
                    index += (prevIndex - index) / 2;
                }
                else
                {
                    Console.WriteLine("Moving left");
                    index -= (prevIndex - index) / 2;
                }
                prevIndex = index;
            }

            return -1;
        }
    }
}
