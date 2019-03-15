using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centuryFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1988;
            
            centuryFromYear(year);
           
        }

        public static int centuryFromYear(int year)
        {
                 
            int century = 0;
            if(year % 100 == 0)
            {
                century = year / 100;
                Console.WriteLine("a: " + century);
            }
            else
            {
                century = (year / 100) + 1;
                Console.WriteLine("century: " + century);
            }

            return century;
        }

       
    }
}        


    

