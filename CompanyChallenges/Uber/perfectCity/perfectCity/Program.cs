using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfectCity
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] departure = { 0.4, 1 };
            //double[] destination = { 0.9, 3 };
            // expected output = 2.7;

            double[] departure = { 0.9, 6 };
            double[] destination = { 1.1, 5 };
            // expected output = 1.2;

            City myCity = new City(departure, destination);
            double result = myCity.perfectCity(myCity);
            Console.WriteLine("result: " + result);
        }
    }
}
