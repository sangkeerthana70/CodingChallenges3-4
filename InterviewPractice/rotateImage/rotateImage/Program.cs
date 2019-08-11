using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotateImage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[][]
            {
                new int[] {1, 2, 3 },
                new int[] {4, 5, 6 },
                new int[] {7, 8, 9 }
            };
            //rotateImage(a);

            PrintArray(rotateImage(a));
            //rotateImage(a) =
 
            // [[7, 4, 1],
            // [8, 5, 2],
            // [9, 6, 3]]



        }
        static int[][] rotateImage(int[][] a)
        {
            int[][] result = new int[a.Length][];

            int rowLength = a.Length;
            //Console.WriteLine("rowLength " + rowLength);
            int colLength = a[0].Length;
            int k;
            
            for(int i = 0; i < colLength; i++)
            {
                result[i] = new int[a.Length];

                for(int j = rowLength-1; j >= 0; j--)
                {
                    Console.WriteLine("i = {0}, j = {1} ", i, j);
                    k = (rowLength -1) -j ;

                    Console.WriteLine("k = " + k);
                    Console.WriteLine("a[j][i] = " + a[j][i]);
                    result[i][k] = a[j][i];
                    Console.WriteLine("result[i][k] = " + result[i][k]);
                }
            }
            
            return result;

        }
        
        static void PrintArray(int[][] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }

            
        }
        

    }
}
