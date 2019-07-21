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
		
		for(int i = 0; i < inputArray.Length; i++)
		{
		   bool repeating = findUnique(inputArray[i]); 
			
			if(!(repeating))
				return inputArray[i];
			
		}
		return -1;
    
   
	}

	 bool findUnique(int element)
	{
		string number = Convert.ToString(element);
		//Console.WriteLine(number);
		for(int i = 0; i < number.Length ; i++)
		{
			for(int j = i+1;  j < number.Length; j++)
			{
				if(number[i] == number[j])
				{
					return true;

				}
			}
			
		}
		return false;

	}
}