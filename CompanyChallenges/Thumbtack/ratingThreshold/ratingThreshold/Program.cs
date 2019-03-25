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

            int[] totalCount = new int[ratings.Length];
            double total = 0;
            double average = 0;
            int count = 0;
            
            for(int i = 0; i < ratings.GetLength(0); i++)
            {
                total = 0;
                int[] innerArray = ratings[i];
                Console.WriteLine(String.Join(" ", innerArray));
                System.Console.WriteLine("Element({0}): ", i);
                
                for (int j = 0; j < innerArray.Length; j++)
                {                   
                    Console.WriteLine("in nested for loop");
                    
                    System.Console.Write("ratings: " + ratings[i][j]+ "");
                    total += ratings[i][j];
                }
                Console.WriteLine("total: " + total);
                average = total / innerArray.Length;
                Console.WriteLine("average: " + average);

                if (average < threshold)
                {
                    count = Array.IndexOf(ratings, innerArray);
                    totalCount[i] = count;

                }
            }
            return totalCount;
            

            
        }


    }
}
