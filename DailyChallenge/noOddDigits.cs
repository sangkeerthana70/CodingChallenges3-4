using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		int n = 12345678;
		int result = noOddDigits(n);
		Console.WriteLine("result " + result);
	}
	
	/*
	Given a non-negative integer number, remove all of its odd digits (if all of the digits are removed, return zero).
	*/
	
	static int noOddDigits(int n) {

    int quotient = n;
        int remainder = 0;
		string m = "";
		while(quotient!= 0)
		{			
			 // Continue dividing the quotient by 10 until you get a quotient of zero
			remainder = quotient % 10;
			//Console.WriteLine("remainder: " + remainder);
			if(remainder % 2 == 0)
			{
				//return false;
				m += remainder;
                Console.WriteLine("m " + m);
			}
			quotient = quotient / 10;
			//Console.WriteLine("quotient: " + quotient);			
		}	
		char[] arr = m.ToCharArray();
        Array.Reverse(arr);
        arr.ToString();
		return  Convert.ToInt32(new string(arr));	
    
}

}