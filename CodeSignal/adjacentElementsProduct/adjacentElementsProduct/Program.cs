using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adjacentElementsProduct
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] inputArray = new int[] { 4, 1, 2, 3, 1, 5 };
            int[] inputArray = new int[] { -23, 4, -3, 8, -12 };
            int result = adjacentElementsProduct(inputArray);
            Console.WriteLine("result: " + result);
        }

        public static int adjacentElementsProduct(int[] inputArray)
        {

            int product = int.MinValue;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] * inputArray[i + 1] > product)
                {
                    product = inputArray[i] * inputArray[i + 1];
                    //Console.WriteLine("product in loop: " + product);
                }
                
            }
            return product;
        }

    }
}
