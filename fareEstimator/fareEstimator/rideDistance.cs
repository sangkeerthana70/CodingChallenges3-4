using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fareEstimator
{
    public class rideDistance
    {
        public int ride_distance;
        public double[] cost_per_mile;

        public rideDistance(int rideDistance, double[] costPerMile)
        {
            this.ride_distance = rideDistance;
            this.cost_per_mile = costPerMile;
        }

        public double[] calcCostPerMile(int rd, double[] costPerMile)
        {
            double[] estimateCostPerMile = new double[costPerMile.Length];

            for(var i = 0; i < costPerMile.Length; i++)
            {
                estimateCostPerMile[i] = rd * costPerMile[i];
                Console.WriteLine("rd: " + rd);
                Console.WriteLine("cpmile[i]: " + costPerMile[i]);
                Console.WriteLine(costPerMile[i]);
            }
            return estimateCostPerMile;
        }
    }
}
