using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domainType
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] domains = new string[] { "en.wiki.org", "codesignal.com", "happy.net", "code.info" };
            string[] result = domainType(domains);
            Console.WriteLine(String.Join(" ", result));
        }

        public static string[] domainType(string[] domains)
        {
            string[] domainType = new string[domains.Length];

            for(var i = 0; i < domains.Length; i++)
            {
                string[] strSplit = domains[i].Split('.');
                foreach (string word in strSplit)
                {
                    Console.WriteLine("WORD: " + word);
                    if(word == "org")
                    {
                        domainType[i] = "organization";
                    }
                    if(word == "com")
                    {
                        domainType[i] = "commercial";
                    }
                    if(word == "net")
                    {
                        domainType[i] = "network";
                    }
                    if(word == "info")
                    {
                        domainType[i] = "information";
                    }
                }
                
            }
            return domainType;

        }

    }
}
