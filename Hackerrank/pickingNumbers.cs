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
		int numbers = 0;
		int result = Int32.MinValue;
		for(int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine("i" + i);
			for(int j = i+1; j < arr.Length -1; j++)
			{
				if(Math.Abs(arr[i] - arr[j]) <= 1)
				{
					Console.WriteLine(arr[i]);
					Console.WriteLine(arr[j]);
					numbers +=1;
					Console.WriteLine("numbers " + numbers);
				}
			}
		}
		Console.WriteLine("numbers " + numbers);
		result = numbers+1;
		Console.WriteLine("result " + result);
		return result;
    }
}