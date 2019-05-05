using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 15;
            int wt1 = 2;
            int v2 = 20;
            int wt2 = 3;
            int maxW = 2;
            Console.WriteLine(knapsackLight(v1, wt1, v2, wt2, maxW));
        }
        /*
         * You found two items in a treasure chest! The first item weighs weight1 and is worth 
         * value1, and the second item weighs weight2 and is worth value2. What is the total 
         * maximum value of the items you can take with you, assuming that your max weight 
         * capacity is maxW and you can't come back for the items later?
         * 
         */

        static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (weight1 + weight2 <= maxW)
            {
                return value1 + value2;
            }


            if ((weight1 > maxW) && (weight2 > maxW))
            {
                return 0;

            }

            if ((maxW >= weight1) && (maxW >= weight2))
            {
                return Math.Max(value1, value2);

            }

            if (maxW >= weight1)
            {
                return value1;
            }

            return value2;

        }

    }
}
