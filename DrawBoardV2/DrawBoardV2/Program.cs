using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height of board between 2 and 30: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of board between 2 and 30");
            int width = Convert.ToInt32(Console.ReadLine());

            if (height < 2 || height > 30)
            {
                Console.WriteLine("Please enter a valid height");
            }
            if(width < 2 || width > 30)
            {
                Console.WriteLine("Please enter a valid height");
            }

            //DrawBoard(width, height);

            DrawBoard myBoard = new DrawBoard(width, height);
            // call each function DrawRows and DrawSeparator for a specified height.
            int n = (2 * height) - 1;
            for (var i = 0; i < n; i++)
            {
                // call DrawRows for even
                if ((i % 2) == 0)
                {
                    myBoard.DrawRows(width);
                }
                else
                {
                    // call Drawseparator for odd
                    myBoard.DrawSeparator(width);
                }
            }
            Console.WriteLine();





        }
       
        
    }
}
