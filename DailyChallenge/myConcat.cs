


using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		string [] stringArray = { "Code", "Fight", "On", "!"};
		string separator = "/";
		string result = myConcat(stringArray, separator);
		Console.WriteLine("result: " + result);
	}
	
	/*
		Concatenate given strings using a specific separator.

		Example

		For strings = ["Code", "Fight", "On", "!"] and separator = "/", the output should be
		myConcat(strings, separator) = "Code/Fight/On/!/".
	*/
	
	static string myConcat(string[] strings, string separator) {
    
		//return String.Join(separator, strings);
		
		string result = "";
		foreach(string word in strings)
		{
		   result += String.Concat(word) + separator;
		}
		return result;
    
	}
}

	