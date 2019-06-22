using System;
/*

Given an array of integers, find the number of inversions it contains.
Inversions-
   Two elements of the array a stored at positions i and j form an inversion if a[i] > a[j] and i < j.

Example

For inputArray = [1, 3, 2, 0], the output should be
countInversionsNaive(inputArray) = 4.	

*/				
public class Program
{
	public static void Main()
	{
		int []inputArray = new int[] {1, 3, 2, 0};
		int res = countInversionsNaive(inputArray);
		Console.WriteLine("res: "+ res);
	}
	static int countInversionsNaive(int[] inputArray) {
		int inversion = 0;
		for(int i = 0; i < inputArray.Length; i++){
		   for(int j = 1; j < inputArray.Length; j++)
		   {
			   if(inputArray[i] > inputArray[j] && i < j)
			   {
				   inversion += 1;
			   }
		   }
		}
		return inversion;

}

}