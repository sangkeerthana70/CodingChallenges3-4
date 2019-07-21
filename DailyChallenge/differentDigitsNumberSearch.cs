using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		int [] inputArray = {22, 111, 101, 124, 33, 30};
		int result = differentDigitsNumberSearch(inputArray);
	}
	
	static int differentDigitsNumberSearch(int[] inputArray) {
		int nonRepeating = 0;
		for(int i = 0; i < inputArray.Length; i++)
		{
		   bool repeating = findNonRepeatingNumber(inputArray[i]); 
			Console.WriteLine(repeating);

		}
    	return nonRepeating;
   
}

	static  bool findNonRepeatingNumber(int element)
	{
		string number = Convert.ToString(element);
		Console.WriteLine(number);
		for(int i = 0; i < number.Length -1 ; i++)
		{
			if(number[i] == number[i+1])
			{
				return true;
				
			}
		}
		return false;
	}
}