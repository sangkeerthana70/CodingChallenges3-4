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

        }
        static string cipher26(string message)
        {
            
            int alphaIndex = 0;
            
            
            char letter = ' ';
            string encrpt = "";
            List<char> decryptMessage = new List<char>();
            for(int i = 0; i < message.Length; i++)
            {
                Console.WriteLine("i = " + i);
                Console.WriteLine("message[i] = " + message[i] + " " + (int)message[i]);
                alphaIndex = Math.Abs(message[i] - 'a') ;
                Console.WriteLine("alphaIndex = " + alphaIndex);

                //decipherIndex.Add((char)alphaIndex);
                letter = ((char)(alphaIndex % 26 + 'a'));
                
                encrpt += letter % 26;
                Console.WriteLine("encrypt: " + encrpt);
                
            }
            Console.WriteLine("decryptMessage : " + String.Join(",", decryptMessage));

            return "";
        }

    }
}
