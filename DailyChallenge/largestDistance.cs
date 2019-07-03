using System;
					
public class Program
{
	public static void Main()
	{
		int[] a = new int[] { 7, 2, 3, 8, 2, 10, 9, 7 };
		int result = largestDistance(a);
		Console.WriteLine("result " + result);
	}
	
	static int largestDistance(int[] a) {
		int max = Int32.MinValue;
		int diff = 0;
		//int diff2 = 0;
		for(int i = 0; i < a.Length; i= i+2)
		{
			
			for(int j = 2; j < a.Length; j++)
			{
				Console.WriteLine("a[i] " + a[i]);
				Console.WriteLine("a[j] " + a[j]);
				diff = Math.Abs(a[i] - a[j]);
				if(diff > max)
					max = diff;
				Console.WriteLine("max " + max);
				i++;
			}
			
		}
		return max;
	}

}
