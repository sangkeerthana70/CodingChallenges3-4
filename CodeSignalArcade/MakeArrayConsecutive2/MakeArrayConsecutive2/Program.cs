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
        /*
        Ratiorg got statues of different sizes as a present from CodeMaster for his 
            birthday, each statue having an non-negative integer size.Since he likes 
            to make things perfect, he wants to arrange them from smallest to largest
            so that each statue will be bigger than the previous one exactly by 1.
            He may need some additional statues to be able to accomplish that.Help him
                figure out the minimum number of additional statues needed.
         */

        public static int makeArrayConsecutive2(int[] statues)
        {           
            Array.Sort(statues);
            //Console.WriteLine(String.Join(",", statues));
            int statuesNeeded = 0;
            for (int i = 0; i < statues.Length - 1; i++)
            {
                
                if(statues[i] + 1 != statues[i + 1])
                {
                    int difference = Math.Abs(statues[i] - statues[i + 1]);                   
                    statuesNeeded += Math.Abs(difference - 1);                   
                }
            }
            return statuesNeeded;
        }

    }
}
