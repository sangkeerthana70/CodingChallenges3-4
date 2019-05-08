using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orthogonalLines
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line1 = { 1, 0, 100 };
            int[] line2 = { 0, 100, -100 };
            bool result = orthogonalLines(line1, line2);
            Console.WriteLine("result: " + result);
        }

        static bool orthogonalLines(int[] line1, int[] line2)
        {
            int sum = 0;
            Console.WriteLine("sum: " + sum);
            for (int i = 0; i < line1.Length; i++)
            {
                
                Console.WriteLine("i : " + i);
                Console.WriteLine("line1[i]: " + line1[i]);
                Console.WriteLine("line2[i]: " + line2[i]);
                sum = sum + line1[i] * line2[i];
                Console.WriteLine("sum in loop: " + sum);

            }
            if(sum < 1)
            {
                return true;
            }
            return false;
        }

    }
}
