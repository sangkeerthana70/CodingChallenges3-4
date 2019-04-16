using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almostIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[] { 1, 3, 2, 1 };
            bool result = almostIncreasingSequence(sequence);
            Console.WriteLine("result: " + result);
        }

        public static bool almostIncreasingSequence(int[] sequence)
        {

            //Array.Sort(sequence);
            //Console.WriteLine(String.Join(",", sequence));
            for(int i = 0; i < sequence.Length -1; i++)
            {
                Console.WriteLine("i is: " + i);
                if(sequence[i] > sequence[i + 1])
                {
                    Console.WriteLine("sequence[i] : " + sequence[i]);
                    Console.WriteLine("sequence[i+1]: " + sequence[i + 1]);
                    int difference = Math.Abs(sequence[i] - sequence[i + 1]);
                    Console.WriteLine("difference: " + difference);
                    return false;
                }
            }
            
            return true;
        }
        

    }

}
