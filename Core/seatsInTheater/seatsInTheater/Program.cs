using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seatsInTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCols = 16;
            int nRows = 11;
            int col = 5;
            int row = 3;
            int result = seatsInTheater(nCols, nRows, col, row);
            Console.WriteLine("result: " + result);
        }

        static int seatsInTheater(int nCols, int nRows, int col, int row)
        {
            int remainingColumns = nCols - (col -1);
            Console.WriteLine(remainingColumns);
            int remainingRows = nRows - row;
            Console.WriteLine(remainingRows);
            int peopleBlocked = remainingColumns * remainingRows;
            Console.WriteLine(peopleBlocked);
            return peopleBlocked;
        }

    }
}
