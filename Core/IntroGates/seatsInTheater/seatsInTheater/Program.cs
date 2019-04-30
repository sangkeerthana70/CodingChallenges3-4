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
            int nCols = 60;
            int nRows = 100;
            int col = 60;
            int row = 1;
            int result = seatsInTheater(nCols, nRows, col, row);
            Console.WriteLine("result: " + result);
        }

        static int seatsInTheater(int nCols, int nRows, int col, int row)
        {
            int remainingColumns = nCols - (col -1);            
            int remainingRows = nRows - row;           
            int peopleBlocked = remainingColumns * remainingRows;           
            return peopleBlocked;
        }

    }
}
