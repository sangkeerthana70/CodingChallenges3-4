using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapDiagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[4][];
            matrix[0] = new int[] { 1, 2, 3, 4 };
            matrix[1] = new int[] { 5, 6, 7, 8 };
            matrix[2] = new int[] { 9, 10, 11, 12 };
            matrix[3] = new int[] { 13, 14, 14, 16 };

            swapDiagonals(matrix);
        }

        static int[][] swapDiagonals(int[][] matrix)
        {
            int length = matrix.Length -1;
            for(int row = 0; row <= length; row++)
            {
                int swap = matrix[row][row];
                matrix[row][row] = matrix[row][length - row];
                Console.WriteLine("matrix[row][row]: " + matrix[row][row]);
                matrix[row][length - row] = swap;
                Console.WriteLine("matrix[row][length - row]: " + matrix[row][length - row]);
            }

            return matrix;
        }

    }
}
