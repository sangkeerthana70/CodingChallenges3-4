using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 1, 3, 1 };
            bool result = isArithmeticProgression(sequence);
            Console.WriteLine("result: " + result);
        }

        static bool isArithmeticProgression(int[] sequence)
        {
            int difference =  (sequence[0] - sequence[1]);          
            for (int num = 0; num < sequence.Length - 1; num++)
            {
                if((sequence[num] - sequence[num + 1]) != difference)
                {
                    //Console.WriteLine("diff in loop : " + (sequence[num] - sequence[num + 1]));
                    return false;
                }
                           
            }
            return true;
        }
    }
}
