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
            int ride_time = 15;
            double[] cost_per_minute = { 0.2, 0.34, 0.35, 0.45, 1 };
            int ride_distance = 9;
            double[] cost_per_mile = { 1.1, 1.8, 1.9, 1.7, 5 };
            rideTime rt = new rideTime(ride_time, cost_per_minute);

            double[] res = rt.calcCostPerMinute(ride_time, cost_per_minute);

            //Console.WriteLine(String.Join(" ", res));

            rideDistance rd = new rideDistance(ride_distance, cost_per_mile);
            double[] res1 = rd.calcCostPerMile(ride_distance, cost_per_mile);
            //Console.WriteLine(String.Join(" ", res1));

            double[] totalFareResults = totalFare(res, res1);
            Console.WriteLine(String.Join(" ", totalFareResults));
            
        }
        public static double[] totalFare(double[] res, double[] res1)
        {
            double[] totalFare = new double[res.Length];
            for (var i = 0; i < res.Length; i++)
            {
                totalFare[i] = res[i] + res1[i];
            }
            return totalFare;
        }
    }

}
