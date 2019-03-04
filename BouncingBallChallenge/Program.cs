using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBallChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            double floorHeight = 10;
            double bounceRate = 0.66;
            double windowHeight = 1.5;

            int result = bouncingBall(floorHeight, bounceRate, windowHeight);
            Console.WriteLine("result: " + result);

        }

        

        public static int bouncingBall(double h, double bounce, double window)
        {
            // your code
            if ((h < 0) || (bounce < 0 || bounce > 1) || (window >= h))
            {

                return -1;
            }

            // set the variable motherSees to 1 initially
            int motherSees = 1;

            // set reboundHeight to total height
            double reboundHeight = h;

            while (true)
            {
                reboundHeight = reboundHeight * bounce;

                if(reboundHeight < window)
                {
                    break;
                }
                motherSees += 2;
            }
            return motherSees;
        }
        
    }
}
