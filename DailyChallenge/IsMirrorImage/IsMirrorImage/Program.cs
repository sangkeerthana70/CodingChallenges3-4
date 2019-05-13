using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorImage
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "xaxbbbxx";
            int result = CheckMirrorImage(s);
            Console.WriteLine("result : " + result);
        }

        // In this challenge, you will be given a string. You must split it into two 
        // contiguous substrings, then determine the minimum number of characters to 
        // change to make the two substrings mirror images of one another.
        //Eg:For a string "xaxbbbxx" breaking it into two substrings would be "xaxb" and "bbxx"
        // for x in subString 1 should be x in subString 2 resulting in a reverse order of "bxax"
        // if it is not  reversed find the minimum number of characters needed to change to get the 
        // reversed subString of 1 in subString 2
        static int CheckMirrorImage(string s)
        {
            if (s.Length % 2 != 0)
            {
                return -1;
            }

            int subStrLength = s.Length / 2;
            
            string subStr1 = s.Substring(0, subStrLength);
            
            string subStr2 = s.Substring(subStrLength);
           

            int uncommonChar = 0;
            for (int i = 0; i < subStrLength; i++)
            {
                if (!(subStr1[i] == subStr2[subStrLength - (i + 1)]))
                {
                    uncommonChar++;
                    //Console.WriteLine(subStr2[subStrLength - (i + 1)]);
                    //Console.WriteLine(subStr1[i]);
                }
            }


            return uncommonChar;

        }
    }
}
