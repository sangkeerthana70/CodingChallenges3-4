using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateCheckChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime input = new DateTime(2012, 1, 1);
            decimal result = ConvertToDecimal(input);
            Console.WriteLine("result :" + result);

        }
        static decimal ConvertToDecimal(DateTime input)
        {
            /* Method-1
            decimal decimalValOfMonth;
            decimal decimalValOfYear;
     
            DateTime currentdate = DateTime.Now;
            decimalValOfYear = (currentdate.Year - input.Year);
            

           
            decimalValOfMonth = currentdate.Month - input.Month;

            // convert the concatenated string to decimal
            return Convert.ToDecimal(decimalValOfYear + "." + decimalValOfMonth);
            */
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            /*Method-2 using TimeSpan
            DateTime currentDate = DateTime.Now;
            TimeSpan difference = currentDate - input;

            
            Console.WriteLine("   {0,-35} {1,20}", "Total Number of Days:", difference.TotalDays/365);

            //use Math.Round to get two decimal values in the decimal          
            return Math.Round(Convert.ToDecimal(difference.TotalDays / 365), 2);
            */
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Method-3 
            //if using milliseconds to calculate the difference between two years
            //millseconds/1000/60/60/24/365
            //convert milliseconds to seconds to minute to hour to days.

            DateTime currentDate = DateTime.Now;
            TimeSpan difference = currentDate - input;
            Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", difference.TotalMilliseconds);
            double milliseconds = difference.TotalMilliseconds;
            return Math.Round(Convert.ToDecimal(milliseconds/1000/60/60/24/365), 2);
        }


    }
}
