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
        }

        static int matrixElementsSum(int[][] matrix)
        {
            Console.WriteLine("rows: " + matrix.GetLength(0));
            
            int sum = 0;
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] floor = matrix[row];
                for (int column = 0; column < floor.Length; column++)
                {
                    
                    if(matrix[row][column] != 0)
                    {
                        sum += matrix[row][column];
                        Console.WriteLine("sum: " + sum);
                    }
                }
            }
            return sum;

        }

    }
}
