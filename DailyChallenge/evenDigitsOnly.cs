using System;
					
public class Program
{
	public static void Main()
	{
		int n = 642386;
		bool result = evenDigitsOnly(n);
		Console.WriteLine(result);
	}
	
	static bool evenDigitsOnly(int n) {
		int quotient = n;
        int remainder = 0;
		
		while(quotient!= 0)
		{			
			 // Continue dividing the quotient by 10 until you get a quotient of zero
			remainder = quotient % 10;
			//Console.WriteLine("remainder: " + remainder);
			if(remainder % 2 != 0)
			{
				return false;
			}
			quotient = quotient / 10;
			//Console.WriteLine("quotient: " + quotient);			
		}	
		return true;	
	}

}