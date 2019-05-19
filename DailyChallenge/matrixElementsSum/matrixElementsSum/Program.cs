using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixElementsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 1, 1, 0 };
            matrix[1] = new int[] { 0, 5, 0, 1 };
            matrix[2] = new int[] { 2, 1, 3, 10 };
            int result = matrixElementsSum(matrix);
            Console.WriteLine(result);
        }

        static int matrixElementsSum(int[][] matrix)
        {
            int sum = 0;
            

            int floors = matrix.Length;
            // since it is a rectangular matrix
            int rooms = matrix[0].Length;

            Console.WriteLine("floors = {0}; rooms = {1}",floors,rooms);

            for (int i = 0; i < rooms; i++)
            {
                for (int j = 0; j < floors; j ++)
                {
                    if (matrix[j][i] == 0)
                    {
                        break;
                    }
                    sum += matrix[j][i];
                }
            }
            return sum;

        }

    }
}
