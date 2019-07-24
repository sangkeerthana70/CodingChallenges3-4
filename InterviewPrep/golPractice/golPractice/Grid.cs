using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golPractice
{
    public class Grid
    {
        public bool[,] grid { get; set; }

        public Grid(int rows, int cols)
        {
            this.grid = new bool[rows, cols];

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {

                }
            }
        }
    }
}
