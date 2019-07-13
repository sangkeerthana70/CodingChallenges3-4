using System;

					
public class Program
{
	public static void Main()
	{
		int len = 10;
		int width = 10;
		char symbol1 = 'o';
		char symbol2 = 'x';
		PrintChars(len, width, symbol1, symbol2);
		//Console.WriteLine(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
	}
	static void PrintChars(int len, int width, char symbol1, char symbol2){
		
		for(int i = 0; i < len; i++)
		{
			for(int j = 0; j < width; j++)
			{
				if ( (i == 0) || (i == len -1) || (j == 0) || (j == width -1))
				{
					Console.Write(symbol1);
				}
				else 
				{
					Console.Write(symbol2);
				}
			}
			Console.WriteLine();
		}
	
	}
	
	/*
	
	output
	
	oooooooooo
	oxxxxxxxxo
	oxxxxxxxxo
	oxxxxxxxxo
	oxxxxxxxxo
	oxxxxxxxxo
	oxxxxxxxxo
	oxxxxxxxxo
	oxxxxxxxxo
	oooooooooo
	*/
}