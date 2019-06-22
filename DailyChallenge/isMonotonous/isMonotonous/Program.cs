using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isMonotonous
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 5, 3 , -2 };
            bool result = isMonotonous(sequence);
            Console.WriteLine("result " + result);
        }

        static bool isMonotonous(int[] sequence)
        {
            if (sequence.Length == 1)
            {
                return true;
            }
            bool order; 
            
            if(sequence[0] > sequence[1])
            {
                order = true;
            }
            else
            {
                order = false;
            }

            for(int i = 0; i < sequence.Length - 1; i++)
            {
                // if not strictly increasing 
                if ((!(sequence[i] < sequence[i + 1])) && (order == false) || (sequence[i] == sequence[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
