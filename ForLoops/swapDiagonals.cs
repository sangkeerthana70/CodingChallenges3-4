using System;
					
public class Program
{
	public static void Main()
	{
		int[][] arr = new int[5][];
		arr[0] = new int[] {1, 2, 3, 4 , 0};
		arr[1] = new int[] {5, 6, 7, 8, 9};
		arr[2] = new int[] {9, 1, 1, 2, 2};
		arr[3] = new int[] {3, 4, 5, 6, 2};
		arr[4] = new int[] {0, 2, 5, 7, 9};
		
		PrintArray(arr);
		Console.WriteLine();
		PrintArray(SwapDiagonals(arr));
	}
	
	static int[][] SwapDiagonals(int[][] arr)
	{
		int length = arr[0].Length -1;
		//Console.WriteLine("length " + length);
		
			for(int j = 0; j < arr[0].Length; j++)
			{
				//Console.WriteLine("length " + (length -j));
				int temp = arr[j][j];
				//Console.WriteLine("temp " + temp);
				arr[j][j] = arr[j][length -j];
				arr[j][length -j] = temp;
			}
			return arr;
	}
	static void PrintArray(int[][] arr)
	{
		for(int i = 0; i < arr.Length; i++)
		{
			for(int j = 0; j < arr[0].Length; j++)
			{
				Console.Write(arr[i][j] + " ");
				
			}
			Console.WriteLine();
			
		}
		
		
	}
}