using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmeticExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            int c = 2;
            bool result = arithmeticExpression(a, b, c);
            Console.WriteLine("result: " + result);
        }

        static bool arithmeticExpression(int a, int b, int c)
        {
            if ((a + b) == c)         
                return true;               
            else if ((a - b) == c)
                return true;
                
            else if ((a * b) == c) 
                return true;
                
            else if ((1.0 * a / b) == c)// since integer division returns a whole number to get a float quotient multiply 'a' with 1.0
                return true;
            else
                return false;
        }

    }
}
