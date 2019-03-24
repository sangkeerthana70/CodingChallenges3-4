using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfectCity
{
    public class City
    {
        double[] departure { get; set; }
        double[] destination { get; set; }

        public City(double []depart, double[] destiny)
        {
            this.departure = depart;
            this.destination = destiny;
        }
        public double perfectCity(City data)
        {
            double shortestTime = 0;
            double te = 0;
            double temp = 0;
            double temp1 = 0;
            double temp2 = 0;
            for (int i = 0; i < departure.Length - 1; i++)
            {
                Console.WriteLine("Ceiling: " + Math.Ceiling(departure[i]));
                if (departure[i] < Math.Ceiling(departure[i]))
                {
                    temp = Math.Abs(departure[i] - Math.Ceiling(departure[i]));
                    Console.WriteLine("temp: " + temp);
                }
                //te = Math.Abs(temp + destination[i]);
                //Console.WriteLine("te: " + te);
                temp1 = Math.Abs(departure[i + 1] - destination[i + 1]);
                Console.WriteLine("temp1: " + temp1);
                temp2 = Math.Abs(destination[i] - Math.Round(destination[i]));
                Console.WriteLine("temp2 " + temp2);
                shortestTime = temp + temp1 + temp2;
                Console.WriteLine(shortestTime);
            }
            return shortestTime;
        }

    }
    
}
