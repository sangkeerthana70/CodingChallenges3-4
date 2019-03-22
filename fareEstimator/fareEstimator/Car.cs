using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fareEstimator
{
    public class Car
    {
        public double cost_per_minute;
        public double cost_per_mile;

        public Car(double costPerMinute, double costPerMile)
        {
            this.cost_per_minute = costPerMinute;
            this.cost_per_mile = costPerMile;
        }

        public double calculateCarFare(int ride_time, int ride_distance)
        {
            double fare = 0;
            fare = (ride_time * cost_per_minute) + (ride_distance * cost_per_mile);
            Console.WriteLine(ride_time * cost_per_minute);
            Console.WriteLine(ride_distance * cost_per_mile);
            Console.WriteLine("totaFare: " + fare);

            return fare;
        }
    }
}
