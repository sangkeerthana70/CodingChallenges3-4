using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimalNumberOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 28;
            int[] coins = { 1, 2, 10};
            int coinsNeeded = minimalNumberOfCoins(coins, price);
            Console.WriteLine(coinsNeeded);
        }

        static int minimalNumberOfCoins(int[] coins, int price)
        {
 
            int remainder = price;

            int coinsNeeded = 0;

            while (remainder != 0)
            {
                // loop starts at the last element since we want to largest element to divide the price with
                for (int i = coins.Length - 1; i > 0; i--)
                {
                    if (remainder == 0)
                    {
                        return coinsNeeded;
                    }

                    if (remainder < coins[i])
                    {
                        continue;
                    }

                    if (remainder >= coins[i])
                    {                        
                        coinsNeeded += remainder / coins[i];
                        remainder = remainder % coins[i]; 
                    }
                }
            }

            return coinsNeeded;

        }
    }
}

