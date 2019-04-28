using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 18;
            int firstNumber = 5;
            int result = circleOfNumbers(n, firstNumber);
            Console.WriteLine(result);

        }
        static int circleOfNumbers(int n, int firstNumber)
        {
            /*
              int halfway = n/2;
              int radiallyOppositeNumber = 0;
              if(firstNumber < halfway)
              {
                  radiallyOppositeNumber = firstNumber + halfway;

              }
              else
              {
                  radiallyOppositeNumber = firstNumber - halfway;

              }


              return radiallyOppositeNumber;
              */
            return (firstNumber + (n / 2)) % n;

        }
    }
}
