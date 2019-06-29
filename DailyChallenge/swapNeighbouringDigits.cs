using System;

namespace swapNeighbouringDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1234;
            int result = swapNeighbouringDigits(n);
            Console.WriteLine("result " + result);

        }
		
		/*
		Given an integer n consisting of an even number of digits, swap pairs of adjacent digits in it, i.e. swap the first digit with the second one, the third digit with the fourth one, etc.

		Example

		For n = 1234, the output should be
		swapNeighbouringDigits(n) = 2143.
		*/

        static int swapNeighbouringDigits(int n)
        {
            
            string num = Convert.ToString(n);
            Console.WriteLine("num as string: " + num);
           
            string result = "";
 
            for(int i = 0; i < num.Length; i= i+2)
            {
                //Console.WriteLine("i = " + i);
               
                result += num[i + 1].ToString() + num[i].ToString();
                //Console.WriteLine("result " + result);
               
            } 
            return Convert.ToInt32(result);
        }

    }
}
