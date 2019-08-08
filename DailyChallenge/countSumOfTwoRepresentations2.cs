using System;
					
public class Program
{
	/*
	Given integers n, l and r, find the number of ways to represent n as a sum of two integers A and B such 
	that l ≤ A ≤ B ≤ r.

	Example

	For n = 6, l = 2, and r = 4, the output should be
	countSumOfTwoRepresentations2(n, l, r) = 2.

	There are just two ways to write 6 as A + B, where 2 ≤ A ≤ B ≤ 4: 6 = 2 + 4 and 6 = 3 + 3.
	*/
	
	
	
	
	public static void Main()
	{
		int n = 6;
		int l = 2;
		int r = 4;
		int result = countSumOfTwoRepresentations2(n, l, r);
		Console.WriteLine("result " + result);
	}
	
	static int countSumOfTwoRepresentations2(int n, int l, int r) {

    int result = 0;
    for(int i = l; i <= r; i++){
		Console.WriteLine("i " + i);
        for (int j = i; j <= r; j++)
        {
			Console.WriteLine("j " + j);
            if ((i + j) == n){
				Console.WriteLine("inside if");
				Console.WriteLine("i " + i);
				Console.WriteLine("j " + j);
				Console.WriteLine("n " + n);
                result++;
            }
        }
        
    }
    
    return result;
}
}