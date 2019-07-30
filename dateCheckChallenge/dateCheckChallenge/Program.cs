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
            decimal decimalvalOfMonth;
            decimal decimalValOfYear;
            Console.WriteLine(input.Year);
            Console.WriteLine(input.Month);
            Console.WriteLine(input.Date);

            DateTime currentdate = DateTime.Now;
            Console.WriteLine(currentdate.Year);


            //decimalval = Convert.ToDecimal(currentdate - input);
            decimalValOfYear = (currentdate.Year - input.Year);
            

           
            decimalvalOfMonth = currentdate.Month - input.Month;


            return Convert.ToDecimal(decimalValOfYear + "." + decimalvalOfMonth);

            
        }
    }
}
