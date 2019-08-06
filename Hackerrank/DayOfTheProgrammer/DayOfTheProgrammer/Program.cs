using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2017;
            string date = dayOfProgrammer(year);
            Console.WriteLine("result: date " + date);

        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            DateTime dateTime = new DateTime();
            
            
            // check if year belongs to Julian
            if (year < 1919)
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
                else
                {
                    Console.WriteLine("in Gregorian non-leap year");
                    int day = 256 - (90+91+62);
                    Console.WriteLine("day " + day);

                    dateTime = new DateTime(year, 9, day);
                    Console.WriteLine("dateTime " + dateTime);

                }
            }
            
            


            return dateTime.ToString();
        }

    }
}
