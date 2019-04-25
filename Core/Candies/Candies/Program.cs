using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 10;
            int result = candies(n, m);
            Console.WriteLine("result: " + result);
        }

        /*
         * n children have got m pieces of candy. They want to eat as much candy as they can, but each 
         * child must eat exactly the same amount of candy as any other child. Determine how many pieces 
         * of candy will be eaten by all the children together. Individual pieces of candy cannot be split.
        */

        static int candies(int n, int m)
        {
            /*
            //Math.round(Converts the values to a double data type and we have to explicitly convert values of m and n to a Decimal
            //to then convert it to a Integer.
            decimal candiesEaten = Math.Round(Convert.ToDecimal(m / n));
            
            Console.WriteLine(candiesEaten.GetType());
            Console.WriteLine("decimal value: " + candiesEaten);
           

            return Convert.ToInt32(candiesEaten) * n;
            */

            return (m / n) * n;
        }

    }
}
