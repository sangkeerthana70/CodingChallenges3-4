using System;
					
public class Program
{
	public static void Main()
	{
		int [] a = {2, 3};
		int[] b = {5, 6};
		int [] result = fractionDivision(a, b);
		Console.WriteLine("result " + String.Join(",", result));										 
	}
	
	static int[] fractionDivision(int[] a, int[] b) {

		int[] reduced = new int[a.Length];
		reduced[0] = a[0] * b[1];
		Console.WriteLine(reduced[0]);
		reduced[1] = a[1] * b[0];
		Console.WriteLine(reduced[1]);
		
		int gcd = FindGCD(reduced);
		Console.WriteLine("gcd " + gcd);
		reduced[0] /= gcd; 
		reduced[1] /= gcd;
		return reduced;
		
	}

	static int FindGCD(int [] arr)
	{
		int minVal  = arr.Min();
		Console.WriteLine("minVal " + minVal);
		bool divisible;
		for(int i = arr[0]; i > 2; i--)
		{
			divisible = true;
			for(int j = 0; j < arr.Length; j++)
			{
				if(arr[j] % i != 0)
				{
					divisible = false;
					break;
				}
			}
			
			if (divisible) 
			{
				return i;
			}
		   
		}
		return 1;
	}
}

/*
 For dividing two fractions a= [2, 3] and b=[5,6]=> reduced arr[2*6 && 3*5]
 arr[12, 15]
 
 Find the greatest common divisor of 12 and 15
 Set the outer loop with the min value in the array
 In the inner loop divide each element in the array with the min value until the mod of that number(i) is
 zero and return i which will be the gcd.
 
 Now divide arr[12, 15] with the gcd and return a reduced fraction
 */