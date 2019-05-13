using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 7;
            int c = 2;
            int result = extraNumber(a, b, c);
            Console.WriteLine("result : " + result);
        }
        static int extraNumber(int a, int b, int c)
        {
            //int thirdInteger = 0;
            if (a == b)
            {
                //thirdInteger = c;
                return c;
            }
            else if(a == c)
            {
                //thirdInteger = b;
                return b;
            }
            else
            {
                //thirdInteger = a;
                return a;
            }
            //return thirdInteger;
        }

    }
}
