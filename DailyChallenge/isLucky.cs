using System;
					
public class Program
{
	public static void Main()
	{
		int n = 1230;
		bool result = isLucky(n);
	}
	
	static bool isLucky(int n) 
	{
		string num = n.ToString();
	   // Console.WriteLine("num " + num);
		int len = num.Length;
		//Console.WriteLine("len " + len);

		string firstHalfDigits = num.Substring(0, len/2);
		//Console.WriteLine("firstHalfDigits " + firstHalfDigits);

		int firstHalfSum = FindSumOfDigits(firstHalfDigits);
		//Console.WriteLine("firstHalfSum " + firstHalfSum);

		string secondHalfDigits = num.Substring((len/2) , len/2);

		//Console.WriteLine("secondHalfDigits " + secondHalfDigits);		
		int secondHalfSum = FindSumOfDigits(secondHalfDigits);

		//Console.WriteLine("secondHalfSum " + secondHalfSum);

		if(firstHalfSum == secondHalfSum)
			return true;

		return false;
	}
	
	
	static int FindSumOfDigits(string digits)
	{
		int sum = 0;
		for(int i = 0; i < digits.Length; i++)
		{
			Console.WriteLine(digits.Length);
			Console.WriteLine("digits[i] " + digits[i]);
			int strToNum = Convert.ToInt32(digits[i].ToString());
			Console.WriteLine("strToNUm " + strToNum);
			 sum += strToNum;
		}
		Console.WriteLine("sum " + sum);
		return sum;
		
		
	}

}