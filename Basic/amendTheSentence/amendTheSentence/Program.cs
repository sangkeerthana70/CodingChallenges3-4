using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amendTheSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "CodesignalIsAwesome";
            string result = amendTheSentence(s);
            Console.WriteLine("result: " + result);

        }
        public static string amendTheSentence(string s)
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (char letter in s)
            {

                if (char.IsUpper(letter) && (sb.Length != 0))
                {
                    Console.WriteLine("letter: " + letter);
                    //char lower = Char.ToLower(letter);

                    //Console.WriteLine("letter after change: " + lower);
                    //sb.Replace(letter, Char.ToLower(letter));
                    sb.Append(' ');
                }

                
                sb.Append(letter);
            }

             
             return sb.ToString().ToLower();
            
        }

    }
}
