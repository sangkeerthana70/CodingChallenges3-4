using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2016;
            string date = dayOfProgrammer(year);

        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            //Console.WriteLine((365 - 256)/12);

            // check if year belongs to Julian
            if(year < 1919)
            {
                Console.WriteLine("year is Julian");
                if(year % 4 == 0)
                {
                    Console.WriteLine("Julian leap year");
                }
            }
            if(year >= 1919)
            {
                Console.WriteLine("year is Gregorian");
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    Console.WriteLine("Gregorian leap year");
                }
            }
            
            


            return "";
        }

    }
}
