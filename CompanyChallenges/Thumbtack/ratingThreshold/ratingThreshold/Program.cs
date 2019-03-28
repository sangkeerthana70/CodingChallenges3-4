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

        public static int[] ratingThreshold(double threshold, int[][] ratingsArr)
        {

            List<int> prosReviewedManually = new List<int> ();
            
            // loop through the length of the first dimension
            for(int ratings = 0; ratings < ratingsArr.GetLength(0); ratings++)
            {
                double total = 0;
                double average = 0;
                //int count = 0;               
                int[] innerArray = ratingsArr[ratings];

                for (int rating = 0; rating < innerArray.Length; rating++)
                {                   
                    //System.Console.WriteLine("ratings[i][j]: " + ratings[i][j]);
                    total += ratingsArr[ratings][rating];
                }
                
                average = total / innerArray.Length;               

                if (average < threshold)
                {
                    //count = Array.IndexOf(ratings, innerArray);
                    //prosReviewedManually.Add(count);
                    prosReviewedManually.Add(Array.IndexOf(ratingsArr, innerArray));
                }
            }
            return prosReviewedManually.ToArray();
            
        }


    }
}
