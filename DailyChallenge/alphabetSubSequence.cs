using System;
					
public class Program
{
	public static void Main()
	{
		string s = "ace";
		bool result = alphabetSubsequence(s);
		Console.WriteLine("result " + result);
				
	}
	
	/*
	Check whether the given string is a subsequence of the plaintext alphabet.

	Example

	For s = "effg", the output should be
	alphabetSubsequence(s) = false;
	*/

	
	static bool alphabetSubsequence(string s) {
	   for(int i = 0; i < s.Length -1; i++)
	   {
		  int charToNum = (int)s[i];
		  Console.WriteLine("charToNum " + charToNum);
		   
		   if(s[i] > s[i+1] || s[i] == s[i+1])
			   return false;
	   }
	  return true;
}

}