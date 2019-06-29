
using System;
					
public class Program
{
	public static void Main()
	{
		string s = "bde";
		bool result = alphabetSubstring(s);
		Console.WriteLine("result " + result);
	}
	
	/*
	Check whether the given string is a substring of the plaintext alphabet.

	Example

	For s = "efghi", the output should be
	alphabetSubstring(s) = true;
	For s = "bde", the output should be
	alphabetSubstring(s) = false.
	*/


	bool alphabetSubstring(string s) {
		
	    //int start = (int)'a';
		//int end = (int)'z';
		
		for (int i = 0; i < s.Length - 1; i++)
		{
			// if the integer difference between current element and next element is not one then return false(not strictly adjacent elements in the alphabet sequence)
			if (!((int)s[i+1] - (int)s[i] == 1))
			{
				return false;
			}
			
		}
		return true;
	}

}