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
		Console.WriteLine("num " + num);
		int len = num.Length;
		Console.WriteLine("len " + len);
		for(int i = 0; i < num.Length-1; i++)
		{
			string digitsSubString = num.Substring(i, len/2);
			Console.WriteLine(digitsSubString);
			//FindSumOfDigits(digitsSubString);
			i++;
		}
		
		
		return false;
	}
	//static int FindSumOfDigits(string digits)
	//{
		
		
	//}
}