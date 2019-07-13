using System;

					
public class Program
{
	public static void Main()
	{
		int len = 4;
		int width = 4;
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
				// print diagonols different from rest of the matrix
				if((i == j) || (j == width - 1-i))
				{
					//Console.WriteLine("i = {0}, j = {1} ",  i , j);
					Console.Write(symbol1 + " ");
				}
				else
				{
					Console.Write(symbol2 + " ");
				}
			}
			Console.WriteLine();
	}
	
	}
}


/* 
	output
	o x x o 
	x o o x 
	x o o x 
	o x x o
*/