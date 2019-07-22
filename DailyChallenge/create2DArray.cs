/*
Given array of integers lengths, create an array of arrays output such that output[i] consists of lengths[i] elements and output[i][j] = j.

Example

For lengths = [1, 2, 0, 4], the output should be

create2DArray(lengths) = [[0], 
                          [0, 1], 
                          [], 
                          [0, 1, 2, 3]]
*/


using System;
					
public class Program
{
	public static void Main()
	{
		int[] lengths = {1, 2, 0, 4};
		int[][] result = create2DArray(lengths);
		//Console.WriteLine("Hello World");
	}
	
	static int[][] create2DArray(int[] lengths) {

		int[][] twoDArray =  new int[lengths.Length][];
		for(int i = 0; i < lengths.Length; i++)
		{
			
			Console.WriteLine(lengths.Length);
				int [] oneDArr = createOneDArray(lengths[i]);
				Console.WriteLine("1Array " + String.Join(",", oneDArr));
				twoDArray[i] = oneDArr;
			}
			
	
		
		return twoDArray;
	}
	
	static int[] createOneDArray(int arrLen)
	{
		int[] oneD = new int[arrLen];
		for(int i = 0; i < arrLen; i++)
		{
			oneD[i] = i;
		}
		return oneD;
	}

    
}

