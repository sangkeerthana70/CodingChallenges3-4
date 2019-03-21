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
        public rideTime(int rt, double[] cpmin)
        {
            this.ride_time = rt;
            this.cost_per_minute = cpmin;
        }

        public double[] calcCostPerMinute(int rt, double[] cpmin)
        {
            double[] costPerMinute = new double[cpmin.Length];

            for(var i = 0; i < cpmin.Length; i++)
            {
                costPerMinute[i] = rt * cpmin[i];
                Console.WriteLine("rt: " + rt);
                Console.WriteLine("cpmin: " + cpmin[i]);
                Console.WriteLine(costPerMinute[i]);
            }

            return costPerMinute;
        }
    }
}
