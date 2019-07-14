using System;
					
public class Program
{
	public static void Main()
	{
		int row  = 5;
		int col = 5;
		
		for(int i = 0; i < row; i++)
		{
			 for (int y = 0; y <= row - i - 2; y++)
            {
				// Console.WriteLine(y);
                Console.Write("*");
            }
            //loop to print hashes
            for (int x = 0; x <= i + 1; x++)
            {
				//Console.WriteLine(x);
                Console.Write("#");
            }
           
			Console.WriteLine();
			
		}
	}
	
	
}