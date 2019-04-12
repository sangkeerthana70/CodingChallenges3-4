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
            Console.WriteLine("result: " + result);
        }

        public static char firstNotRepeatingCharacter(string s)
        {
            Dictionary <char, int> words = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                // if the key already exists increment its value by 1
                if (words.ContainsKey(s[i]))
                {
                    words[s[i]] += 1;
                }
                else
                {
                    // add the new kwy and its value pair
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
