using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneCall
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 2;
            int min1 = 2;
            int min2_10 = 2;
            int min11 = 1;
            int result = phoneCall(min1, min2_10, min11, s);
            Console.WriteLine("result: " + result);
        }

        static int phoneCall(int min1, int min2_10, int min11, int s)
        {

            int firstMinute = s - min1;
            Console.WriteLine("first: " + firstMinute);
            int minutes2Through10 = min2_10 * 9;
            Console.WriteLine("second: " + minutes2Through10);
            int remainingMinutes = firstMinute - minutes2Through10;
            Console.WriteLine("remainingminutes: " + remainingMinutes);
            int minutes11AndUp = remainingMinutes / min11;
            Console.WriteLine("last: " + minutes11AndUp);
            return  1 + minutes2Through10 + minutes11AndUp;
        }
    }

    
}
