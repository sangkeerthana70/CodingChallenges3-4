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
		int[] 1D = new int[arrLen]{};
		for(int i = 0; i < arrLen; i++)
		{
			1D = [i];
		}
		return 1D;
	}

    
}