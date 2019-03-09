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
                Console.WriteLine("Enter width of the board:");
            }

            DrawBoard(width, height);
           


            

           
        }
        public static void DrawBoard(int width, int height)
        {
             
            
            for(var i = 0; i < (2 * height) -1; i++)
            {
                if ((i % 2) == 0)
                {
                    DrawRows(width);
                }
                else
                {
                    DrawSeparator(width);
                }
            }
            Console.WriteLine();
            
        }

        // prints rows of boxes for a specified width
        public static void DrawRows(int width)
        {
            int n = (2 * width) - 1;

            // start i from 0 as 0%2 is 0 which is even
            for(var i = 0; i < n; i++)
            {
                if(i % 2 == 0)
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

        public static void DrawSeparator(int width)
        {
            int n = (2 * width) - 1;

            for(var i = 0; i < n; i++)
            {
                if(i % 2 == 0)
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
