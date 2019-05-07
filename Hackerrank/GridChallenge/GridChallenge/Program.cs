using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                string[] grid = new string[n];

                for (int i = 0; i < n; i++)
                {
                    string gridItem = Console.ReadLine();
                    grid[i] = gridItem;
                }

                string result = gridChallenge(grid);

            }
            */
            string[][] grid = new string[3][];
            grid[0] = new string[] { "e", "b", "a" };
            grid[1] = new string[] { "f", "g", "h" };
            grid[2] = new string[] { "o", "l", "m" };



        }
        // Complete the gridChallenge function below.
        static string gridChallenge(string[] grid)
        {
            for(int i = 0; i < grid.GetLength(0); i++)
            {
                for(int j = 0; j < grid.GetLength(1); j++)
                {

                }
            }
            return "";
        }
    }
}