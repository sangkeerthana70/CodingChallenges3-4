using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percentageGreen
{
    class Program
    {
        static void Main(string[] args)
        {
            int green = 2;
            int total = 5;
            percentageGreen(green, total);

        }

        static int percentageGreen(int green, int total)
        {

            

            double percentage = ((double)green / total) * 100;

            Console.WriteLine(percentage);
            return (int)percentage;
        }

    }
}
