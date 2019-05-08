using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Beautiful Day";
            string result = swapCase(text);
            Console.WriteLine("result: " + result);
        }

        static string swapCase(string text)
        {
            string result = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    result += char.ToLower(text[i]).ToString();
                }
                else
                {
                    result += char.ToUpper(text[i]).ToString();
                }
            }
            return result;

        }

    }
}
