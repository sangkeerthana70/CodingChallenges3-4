﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lateRide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1439;
            int result = lateRide(n);
            Console.WriteLine("result: " + result);

        }
        /* One night you go for a ride on your motorcycle. At 00:00 you start your engine, and the built-in
         * timer automatically begins counting the length of your ride, in minutes. Off you go to explore 
         * the neighborhood.

         * When you finally decide to head back, you realize there's a chance the bridges on your route home 
         * are up, leaving you stranded! Unfortunately, you don't have your watch on you and don't know what time it is. All you know thanks to the bike's timer is that n minutes have passed since 00:00.

         *Using the bike's timer, calculate the current time. Return an answer as the sum of digits that the
         * digital timer in the format hh:mm would show.
         * For n = 240, the output should be
         *lateRide(n) = 4.

         * Since 240 minutes have passed, the current time is 04:00. The digits sum up to 0 + 4 + 0 + 0 = 4, which is the answer.
         */

        static int lateRide(int n)
        {
            int currentTime = 0;
            int hour = n / 60;
            int minutes = n % 60;
            currentTime += hour % 10;
            currentTime += hour / 10;
            currentTime += minutes % 10;
            currentTime += minutes / 10;
 
            return currentTime;
            
        }
    }
}
