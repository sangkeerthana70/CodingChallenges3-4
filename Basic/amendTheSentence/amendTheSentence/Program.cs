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
                if (char.IsUpper(letter))
                {              
                    sb.Append(' ');
                }                
                sb.Append(letter);
            }
            return sb.ToString().ToLower().TrimStart();
            
        }

    }
}
