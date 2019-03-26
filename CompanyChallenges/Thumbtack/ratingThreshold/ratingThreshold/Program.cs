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
            int[][] ratings = new int[3][];
            ratings[0] = new int[] { 3, 4 };
            ratings[1] = new int[] { 3, 3, 3, 4 };
            ratings[2] = new int[] { 4 };
            int [] res = ratingThreshold(threshold, ratings);
            Console.WriteLine(String.Join(" ",res));
        }

        public static int[] ratingThreshold(double threshold, int[][] ratings)
        {

            List<int> totalCount = new List<int> ();
            double total = 0;
            double average = 0;
            int count = 0;
            
            for(int i = 0; i < ratings.GetLength(0); i++)
            {
                total = 0;
                int[] innerArray = ratings[i];

                for (int j = 0; j < innerArray.Length; j++)
                {                   
                    
                    
                    //System.Console.WriteLine("ratings[i][j]: " + ratings[i][j]);
                    total += ratings[i][j];
                }
                
                average = total / innerArray.Length;               

                if (average < threshold)
                {
                    count = Array.IndexOf(ratings, innerArray);
                    totalCount.Add(count);
                }
            }
            return totalCount.ToArray();
            
        }


    }
}
