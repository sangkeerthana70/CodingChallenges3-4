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
                for (int i = coins.Length - 1; i > 0; i--)
                {
                    Console.WriteLine("i : " + i);
                    if (remainder == 0)
                    {
                        return coinsNeeded;
                    }

                    if (remainder < coins[i])
                    {
                        Console.WriteLine("remainder: " + remainder);
                        Console.WriteLine("coins[i]: " + coins[i]);
                        continue;
                    }

                    if (remainder >= coins[i])
                    {
                        Console.WriteLine("remainder: " + remainder);
                        Console.WriteLine("coins[i]: " + coins[i]);
                        coinsNeeded += remainder / coins[i];
                        Console.WriteLine("coinsNeeded: " + coinsNeeded);
                        remainder = remainder % coins[i];
                        Console.WriteLine("remainder: " + remainder);
                    }
                }
            }
            Console.WriteLine("coinsNeeded: " + coinsNeeded);
            return coinsNeeded;

        }
    }
}

