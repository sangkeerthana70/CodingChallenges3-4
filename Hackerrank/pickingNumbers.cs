using System;
					
public class Program
{
	public static void Main()
	{
		int[] arr = new int[] {4, 6, 5, 3, 3, 1};
		int result = pickingNumbers(arr);
		
	}
	 /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(int[] arr)
    {
		int validcount = 0;
		int result = Int32.MinValue;
		for(int i = 0; i < arr.Length; i++)
		{
			validcount = 0;
			Console.WriteLine("i" + i);
			for(int j = 0; j < arr.Length -1; j++)
			{
				if (i == j) continue;
				
				if(Math.Abs(arr[i] - arr[j]) <= 1)
				{
					Console.WriteLine(arr[i]);
					Console.WriteLine(arr[j]);
					validcount +=1;
					Console.WriteLine("validcount " + validcount);
				}
			}
			
			if (validcount > result) result = validcount;
		}
		Console.WriteLine("validcount " + validcount);
		Console.WriteLine("result " + result);
		return result;
    }
}