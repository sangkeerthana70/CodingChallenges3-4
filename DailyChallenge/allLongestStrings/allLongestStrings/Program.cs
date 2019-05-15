using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allLongestStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "enyky","benyky","yely","varennyky" };
            allLongestStrings(inputArray);

        }

        static string[] allLongestStrings(string[] inputArray)
        {

            List<string> output = new List<string>();

            int maxLength = 0;

            for(int i = 0; i < inputArray.Length; i++)
            {
                if(inputArray[i].Length > maxLength)
                {
                    maxLength = inputArray[i].Length;
                }                   
            }
            //Console.WriteLine("maxLength: " + maxLength);
            foreach(string word in inputArray)
            {
                if(word.Length == maxLength)
                {
                    output.Add(word);
                }
            }
            Console.WriteLine(String.Join(",", output));
            return output.ToArray();
        }

    }
}
