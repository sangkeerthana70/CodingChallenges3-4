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
            string address = "prettyandsimple@example.com";
            string result = findEmailDomain(address);
            Console.WriteLine("result " + result);
        }

        static string findEmailDomain(string address)
        {
            string[] strArr = address.Split('@');
            int index = address.IndexOf('@');
            int strlength = address.Length -1;
            if (address.Contains('@')){
                return address.Substring(index + 1);
            }
            return "";
        }

    }
}
