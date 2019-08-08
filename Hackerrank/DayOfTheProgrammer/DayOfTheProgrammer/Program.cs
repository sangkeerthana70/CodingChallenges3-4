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
            bool leapYear = true;
           
            
            // check if year belongs to Julian
            if (year < 1919)
            {
                //Console.WriteLine("year is Julian");
                if(leapYear)
                {
                    //Console.WriteLine("Julian leap year");
                    dateTime = new DateTime(year, 9, 12);

                }
                else
                {
                    dateTime = new DateTime(year, 9, 13);
                }
            }
            if(year >= 1919)
            {
                //Console.WriteLine("year is Gregorian");
                if (leapYear)
                {
                    //Console.WriteLine("Gregorian leap year");
                    
                    dateTime = new DateTime(year, 9, 12);

                }
                else
                {
                    //Console.WriteLine("in Gregorian non-leap year");
                   

                    dateTime = new DateTime(year, 9, 13);
                    
                }
            }

            //Console.WriteLine(dateTime);
           // Console.WriteLine(dateTime.ToString("dd.MM.yyyy"));


            return dateTime.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }

    }
}
