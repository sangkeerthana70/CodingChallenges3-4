using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cipher26
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "thisisencryptedmessage";
            string result = cipher26(message);
            Console.WriteLine("result " + result);
        }
        static string cipher26(string message)
        {
            int alphaIndex = 0;
            char output = ' ';
            int convertBack = 0;
            string outputString = "";
            for(int i = 0; i < message.Length; i++)
            {
                Console.WriteLine("i is: " + i);
                Console.WriteLine("message[i] is: " + message[i]);
                alphaIndex = Math.Abs(message[i] - 'a');
                Console.WriteLine("alpha: " + alphaIndex);

                convertBack = (convertBack + alphaIndex) % 26;
                Console.WriteLine("convertBack " + convertBack);
                output = (char)(convertBack + 'a');
                Console.WriteLine("output: " + output);
                outputString += output;
                Console.WriteLine("result: " + outputString);
            }
            
            return outputString;
        }

    }
}
