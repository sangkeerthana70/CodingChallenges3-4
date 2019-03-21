using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fareEstimator
{
    public class rideTime
    {
        public int ride_time;
        public double[] cost_per_minute;
        public rideTime(int rideTime, double[] costPerMin)
        {
            this.ride_time = rideTime;
            this.cost_per_minute = costPerMin;
        }

        public double[] calcCostPerMinute(int rideTime, double[] costPerMin)
        {
            double[] estimateCostPerMinute = new double[costPerMin.Length];

            for(var i = 0; i < costPerMin.Length; i++)
            {
                estimateCostPerMinute[i] = rideTime * costPerMin[i];
                Console.WriteLine("rt: " + rideTime);
                Console.WriteLine("cpmin: " + costPerMin[i]);
                Console.WriteLine(estimateCostPerMinute[i]);
            }

            return estimateCostPerMinute;
        }
    }
}
