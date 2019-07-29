/*

Given an initial string, switch case of the minimal possible number of letters to make the whole string written in the upper case or in the lower case.

Example

For inputString = "Aba", the output should be
caseUnification(inputString) = "aba";
For inputString = "ABa", the output should be
caseUnification(inputString) = "ABA".

*/

using System;
using System.Globalization;

public class Program
{
	public static void Main()
	{
		string inputString = "Aba";
		string result = caseUnification(inputString);
		Console.WriteLine("result " + result);
	}
	
	static string caseUnification(string inputString) {

		int upperCase = 0;
		int lowerCase = 0;
		string result = "";
		
		for(int i = 0; i < inputString.Length; i++)
		{
			if(char.IsUpper(inputString[i]))
			{
				upperCase++;
				
			}
			if(char.IsLower(inputString[i]))
			{
				lowerCase++;
			}
		}
		
		// Get current culture.
        CultureInfo culture = CultureInfo.CurrentCulture;

		
		if(upperCase > lowerCase)
		{
			 result = inputString.ToUpper(culture);			
		}
		else
		{
			 result = inputString.ToLower(culture);
		}

		return result;
	}


}