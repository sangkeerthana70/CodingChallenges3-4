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
            int[] sequence = { 2, 4, 7 };
            bool result = isArithmeticProgression(sequence);
            Console.WriteLine("result: " + result);
        }

        static bool isArithmeticProgression(int[] sequence)
        {

            for (int num = 0; num < sequence.Length - 1; num++)
            {

                if ((Math.Abs(sequence[num] - sequence[num + 1])) != (Math.Abs(sequence[num + 1] - sequence[num + 2])))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
