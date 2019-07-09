using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		int m = 4;
		int[] flavor = { 1, 4, 5, 3, 2};
		int[] result = icecreamParlor(m,flavor);
		Console.WriteLine("result " + String.Join("," , result));
	}
	
	/*
	Sunny and Johnny like to pool their money and go to the ice cream parlor. Johnny never buys the same flavor that Sunny does. The only other rule they have is that they spend all of their money.

	Given a list of prices for the flavors of ice cream, select the two that will cost all of the money they have.

	For example, they have m =6 to spend and there are flavors costing cost = [1, 3, 4, 5, 6]. The two flavors costing 1 and 5 meet the criteria. Using 1-based indexing, they are at indices 1 and 4.
	
	*/
	
	 // Complete the icecreamParlor function below.
    static int[] icecreamParlor(int m, int[] arr) {
	
		List<int> result   = new List<int>();
		//int[] result = new int[2];
		for(int i = 0; i < arr.Length; i++)
		{
			for(int j = i+1; j < arr.Length; j++)
			{
				if(arr[i] + arr[j] == m)
				{
					Console.WriteLine("1 " + arr[i]);
					Console.WriteLine("2 " + arr[j]);
					Console.WriteLine("i " + i);
					Console.WriteLine("j " + j);
					result.Add(i +1);
					result.Add(j + 1);
					break;
				}
 			}
		}
		return result.ToArray();
			//return result;
    }
}