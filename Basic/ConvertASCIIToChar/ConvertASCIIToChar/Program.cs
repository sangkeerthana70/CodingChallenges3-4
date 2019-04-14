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
            int unicode = 65;
            char character = (char)unicode;
            Console.WriteLine(character);
            string text = character.ToString();
            Console.WriteLine(text);
        }
    }
}
