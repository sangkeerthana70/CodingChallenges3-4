using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeArrayConsecutive2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] statues = new int[] { 6, 2, 3, 8 };
            int result = makeArrayConsecutive2(statues);
            Console.WriteLine("result: " + result);


        }

        public static int makeArrayConsecutive2(int[] statues)
        {
            
            Array.Sort(statues);

            Console.WriteLine(String.Join(",", statues));
            int statuesNeeded = 0;
            for (int i = 0; i < statues.Length - 1; i++)
            {
                
                Console.WriteLine("i is: " + i);
                
                if(statues[i] + 1 != statues[i + 1])
                {
                    Console.WriteLine("inside if");
                    Console.WriteLine("statues[i]: " + statues[i]);
                    Console.WriteLine("statues[i+1]: " + statues[i + 1]);
                    int difference = Math.Abs(statues[i] - statues[i + 1]);
                    Console.WriteLine("difference: " + difference);
                    statuesNeeded += Math.Abs(difference - 1);
                    
                }
            }
            Console.WriteLine("3: " + statuesNeeded);
            return statuesNeeded;
        }

    }
}
