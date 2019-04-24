using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "bcccccccccccccyb";
            char result = firstNotRepeatingCharacter(s);           
        }

        public static char firstNotRepeatingCharacter(string s)
        {
            Dictionary <char, int> words = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {               
                if (words.ContainsKey(s[i]))
                {
                    words[s[i]] += 1;
                }
                else
                {
                    words.Add(s[i], 1);
                }

                
            }
            foreach(KeyValuePair<char,int> letter in words)
            {
                Console.WriteLine("Key: {0}, Value: {1}", letter.Key, letter.Value);
                if(letter.Value == 1)
                {
                    return letter.Key;
                }
            }
            return '_';
        }

    }
}
