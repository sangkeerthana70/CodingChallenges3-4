using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lateRide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 808;
            int result = lateRide(n);
            Console.WriteLine("result: " + result);

        }

        static int lateRide(int n)
        {
            int result = 0;

            int hour = n / 60;
            Console.WriteLine("quo : " + hour);
            
            int minutes = n % 60;
            Console.WriteLine("minutes: " + minutes);

            result += hour % 10;
            Console.WriteLine("res1 " + result);
            result += hour / 10;
            Console.WriteLine("res2 " + result);
            result += minutes % 10;
            Console.WriteLine("res3 " + result);
            result += minutes / 10;
            Console.WriteLine("res4 " + result);





            return result;
            
        }
    }
}
