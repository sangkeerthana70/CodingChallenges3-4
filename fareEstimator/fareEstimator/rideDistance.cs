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

        public rideDistance(int rd, double[] cpmile)
        {
            this.ride_distance = rd;
            this.cost_per_mile = cpmile;
        }

        public double[] calcCostPerMile(int rd, double[] cpmile)
        {
            double[] costPerMile = new double[cpmile.Length];

            for(var i = 0; i < cpmile.Length; i++)
            {
                costPerMile[i] = rd * cpmile[i];
                Console.WriteLine("rd: " + rd);
                Console.WriteLine("cpmile[i]: " + cpmile[i]);
                Console.WriteLine(costPerMile[i]);
            }
            return costPerMile;
        }
    }
}
