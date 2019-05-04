using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findEmailDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            //string address = "prettyandsimple@example.com";
            string address = "\"very.unusual.@.unusual.com\"@usual.com";
            string result = findEmailDomain(address);
            Console.WriteLine("result " + result);
        }

        /*
         * An email address such as "John.Smith@example.com" is made up of a local part ("John.Smith"),
         * an "@" symbol, then a domain part ("example.com").

          The domain name part of an email address may only consist of letters, digits, hyphens and dots.
          The local part, however, also allows a lot of different special characters. 

          Given a valid email address, find its domain part.
        */

        static string findEmailDomain(string address)
        {
            string[] strArr = address.Split('@');
            //int index = address.IndexOf('@');
            int index = address.LastIndexOf('@');
            string result = "";
            int strlength = address.Length -1;
            if (address.Contains('@')){
                result = address.Substring(index + 1);
            }
            return result;
        }

    }
}
