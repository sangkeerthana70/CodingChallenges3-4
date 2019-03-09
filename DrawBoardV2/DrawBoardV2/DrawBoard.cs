using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV2
{
    public class DrawBoard
    {
        int width;
        int height;
        public DrawBoard(int w, int h)
        {
            this.width = w;
            this.height = h;
        }

        // prints rows of boxes for a specified width
        public void DrawRows(int width)
        {
            int n = (2 * width) - 1;

            // start i from 0 as 0 % 2 is 0 which is even
            for (var i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("|");
                }

            }
            Console.WriteLine();


        }

        // prints separator for a specified width not height
        public void DrawSeparator(int width)
        {
            int n = (2 * width) - 1;

            for (var i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();

        }
    }
}
