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
            double threshold = 5;
            int[][] ratings = new int[3][];
            ratings[0] = new int[] { 2, 4, 5, 2, 1, 3, 4 };
            ratings[1] = new int[] { 3, 4, 5, 5, 5, 3, 2 };
            ratings[2] = new int[] { 1, 1, 1, 2, 1, 1 };
            int [] res = ratingThreshold(threshold, ratings);
            Console.WriteLine(String.Join(" ",res));
        }

        public static int[] ratingThreshold(double threshold, int[][] ratings)
        {
            List<int> prosReviewedManually = new List<int> ();

            for(int row = 0; row < ratings.GetLength(0); row++)
            {
                double total = 0;
                double average = 0;
                             
                int[] rating = ratings[row];
                
                for (int column = 0; column < rating.Length; column++)
                {                                     
                    total += ratings[row][column];
                }
                
                average = total / rating.Length;               

                if (average < threshold)
                {
                    prosReviewedManually.Add(Array.IndexOf(ratings, rating));
                }
            }
            return prosReviewedManually.ToArray();           
        }
    }
}
