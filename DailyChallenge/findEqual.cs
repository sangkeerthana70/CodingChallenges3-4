using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		int[] sequence =  { 1, 3, 2, 1 };
		bool result = findEqual(sequence);
		Console.WriteLine("result " + result);
	}
	
	/*
	Given unsorted array of integers, check if it contains at least two equal numbers.

	Example

	For sequence = [1, 3, 2, 1], the output should be
	findEqual(sequence) = true;
	For sequence = [1, 3, 2], the output should be
	findEqual(sequence) = false.
	*/
	
	 static bool findEqual(int[] sequence) {
		Array.Sort(sequence);
		for(int i = 0; i < sequence.Length -1; i++){
			
			if(sequence[i] == sequence[i+1]){
				return true;
			}
		}
		return false;
	}
}