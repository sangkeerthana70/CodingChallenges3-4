using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extractMatrixColumn
{
    class Program
    {
        static void Main(string[] args)
        {
            int column = 2;
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 1, 1, 2 };
            matrix[1] = new int[] { 0, 5, 0, 4 };
            matrix[2] = new int[] { 2, 1, 3, 6};
            int[] result = extractMatrixColumn(matrix, column);
            Console.WriteLine("result : " + String.Join(",", result));
        }
        /*
        Given a rectangular matrix and an integer column, return an array containing the elements of the
        columnth column of the given matrix(the leftmost column is the 0th one).
        For

        matrix = [[1, 1, 1, 2], 
                    [0, 5, 0, 4], 
                    [2, 1, 3, 6]]
        and column = 2, the output should be
        extractMatrixColumn(matrix, column) = [1, 0, 3].
        */

        static int[] extractMatrixColumn(int[][] matrix, int column)
        {
            List<int> resultArr = new List<int>();
            // get column length
            int height = matrix.Length;
            // get individual array in jagged array's length
            int width = matrix[0].Length;
            Console.WriteLine("height = {0}; width = {1}", height, width);
            
            for (int i = 0; i < width; i++)
            {
               
                for(int j = 0; j < height; j++)
                {
                    Console.WriteLine("i = {0}; j = {1}: matrix[i][j] = {2}", i, j, matrix[j][i]);
                    if(i == column)
                    {
                        resultArr.Add(matrix[j][i]);
                    }
                    
                }
            }

            return resultArr.ToArray();

        }

    }
}
