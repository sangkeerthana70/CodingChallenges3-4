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
            int[] sequence = new int[] { 3, 6, 5, 8, 10, 20, 15 };
            bool result = almostIncreasingSequence(sequence);
            Console.WriteLine("result: " + result);
        }

        
        public static bool almostIncreasingSequence(int[] sequence)
        {
            //List<int> newSequence = new List<int>();
            List<int> newSequence = sequence.ToList<int>();
            Console.WriteLine(String.Join(",", newSequence));
            for (int i = 0; i < newSequence.Count; i++)
            {
                Console.WriteLine("i in List: " + i);
                newSequence.RemoveAt(i);
                Console.WriteLine("after removing element at " + i + ": " + String.Join(",", newSequence));
                if (increasingSequence(newSequence))
                {
                    return true;
                }
            }
            
            return false;
        }

        public static bool increasingSequence(List<int> sequence)
        {
            Console.WriteLine(String.Join(",", sequence));
            for (int i = 0; i < sequence.Count - 1; i++)
            {
                Console.WriteLine("i in bool: " + i);
                Console.WriteLine("sequence[i] : " + sequence[i]);
                Console.WriteLine("sequence[i + 1] : " + sequence[i + 1]);
                if (sequence[i] >= sequence[i + 1])
                {
                    Console.WriteLine("inside if");
                    return false;
                }
            }
            return true;
        }

    }

}
