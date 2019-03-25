using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratingThreshold
{
    class Program
    {
        static void Main(string[] args)
        {
            double threshold = 3.5;
            int[][] ratings = new int[5][];
            ratings[0] = new int[] { 3, 4 };
            ratings[1] = new int[] { 3, 3, 3, 4 };
            ratings[2] = new int[] { 4 };
        }

        int[] ratingThreshold(double threshold, int[][] ratings)
        {

            int[] totalCount = new int[ratings.Length];
            foreach (int[] rating in ratings)
            {
                double avg = 0;
                for (var i = 0; i < rating.Length - 1; i++)
                {
                    avg += rating[i] + rating[i + 1];
                    Console.WriteLine("avg before: " + avg);
                    avg = avg / rating.Length;
                    Console.WriteLine("avg after: " + avg);
                    if (avg < threshold)
                    {
                        totalCount[i] += 1;
                    }
                }


            }
            return totalCount;
        }


    }
}
