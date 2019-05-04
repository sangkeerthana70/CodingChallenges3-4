using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 15;
            int[] prices = new int[] { 3, 7, 2, 9, 4 };
            int result = maximumToys(prices, k);
            Console.WriteLine("result : " + result);
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            
            
            int sum = 0;
            int i;
            Array.Sort(prices);
            //Console.WriteLine(String.Join(",", prices));
            for(i = 0; i < prices.Length; i++)
            {
                
                sum += prices[i];
                if(sum > k)
                {
                    break;
                }
            }
            return i;
            


        }

    }
}
