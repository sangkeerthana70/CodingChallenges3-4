using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertASCIIToChar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int unicode = 65;
            char character = (char)unicode;
            Console.WriteLine(character);
            string text = character.ToString();
            Console.WriteLine(text);
            */

            //int[] numbers = new int[] { 67, 80, 65, 79, 86, 66, 75, 71, 81, 69, 90, 79, 68, 65, 73, 88 };
            int[] numbers = new int[] { 73, 65, 77, 83, 65, 77 };
            char[] result = Convert(numbers);
            Console.WriteLine(String.Join(",", result));
        }

        public static char[] Convert(int[] numbers)
        {
            List<char> letter = new List<char>();
            for (var i = 0; i < numbers.Length; i++)
            {

                letter.Add((char)numbers[i]);
                

            }
            char[] result = letter.ToArray();

            return result;

        }
    }
}
