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
            Console.WriteLine("Enter height value between 2 and 30: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(height);
            if(height < 2 || height > 30)
            {
                Console.WriteLine("Please enter a valid height");
            }

            DrawBoard(height);

        }

        public static void DrawBoard(int height)
        {
            int n = (2 * height) - 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    DrawBox(height);
                }
                else
                {
                    DrawSeparator(height);
                }
            }

        }

        //prints first line accross as " |" for the specified height
        public static void DrawBox(int height)
        {
            int n = (2 * height) - 1;
            for (int i = 0; i < n; i++)
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
        // prints second line accross as "-+" for the specified height
        public static void DrawSeparator(int height)
        {
            int n = (2 * height) - 1;
            for (int j = 0; j < n; j++)
            {
                if (j % 2 == 0)
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
