using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fareEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            int ride_time = 30;
            double[] cost_per_minute = { 0.2, 0.35, 0.4, 0.45 };
            int ride_distance = 7;
            double[] cost_per_mile = { 1.1, 1.8, 2.3, 3.5 };

            double[] totalfare = new double[cost_per_mile.Length];
            

            for (var i = 0; i < cost_per_mile.Length; i++)
            {
                Car car = new Car(cost_per_minute[i], cost_per_mile[i]);
                
                totalfare[i] = car.calculateCarFare(ride_time, ride_distance);
                Console.WriteLine("totalFare[i]: " + totalfare[i]);
            }
            Console.WriteLine(String.Join(" ", totalfare));

        }
    }

}
