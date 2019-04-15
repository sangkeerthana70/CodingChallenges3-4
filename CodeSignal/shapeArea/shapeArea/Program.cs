using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int result = shapeArea(n);
            
            Console.WriteLine("result : " + result);
        }

        public static int shapeArea(int n)
        {
            int area = 1;
            int sides = 4;
            int oldArea = 0;
            int append1InterestingPolygon = 0;

            if (n == 1)
            {
                return area;
            }

            
            oldArea = shapeArea(n - 1);
            Console.WriteLine("oldArea: " + oldArea);
            append1InterestingPolygon = (n - 1) * sides;
            Console.WriteLine("no of squares to append: " + append1InterestingPolygon);
            area = append1InterestingPolygon + oldArea;
            return area;
            

        }

    }
}
