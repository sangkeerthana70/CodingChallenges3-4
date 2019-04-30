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
        static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            int maximumValue = 0;
            if(weight1 + weight2 > maxW)
            {
                maximumValue = Math.Max(value1, value2);
            }
            if(weight1 + weight2 == maxW)
            {
                maximumValue = value1 + value2;
            }
            if((weight1  > maxW) || (weight2 > maxW))
            {
                maximumValue = 0;
            }
            if(weight1 == maxW)
            {
                if((value1 < maxW))
                {
                    maximumValue = value2;
                }
                else
                   maximumValue = value1;
            }
            if (weight2 == maxW)
            {
                if ((value2 < maxW))
                {
                    maximumValue = value1;
                }
                else                  
                    maximumValue = value2;
            }
            return maximumValue;


        }

    }
}
