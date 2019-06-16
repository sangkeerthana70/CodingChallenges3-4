using System;
					
public class Program
{
	public static void Main()
	{
		int k = 2;
		int[] arr = new int[] {1, 3, 5, 8, 6, 4, 2 };
		int result = pairs(k, arr);
		Console.WriteLine(result);
	}
	/*
	You will be given an array of integers and a target value. Determine the number of pairs of array elements that have a difference equal to a target value.

	For example, given an array of [1, 2, 3, 4] and a target value of 1, we have three values meeting the condition: , , and .

	Function Description

	Complete the pairs function below. It must return an integer representing the number of element pairs having the required difference.

	pairs has the following parameter(s):

	k: an integer, the target difference
	arr: an array of integers
	*/
	
     // Complete the pairs function below.
    static int pairs(int k, int[] arr) {
        int totalPairs = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = i+1; j < arr.Length; j++){
				// Console.WriteLine("arr[i] " + arr[i]);
				// Console.WriteLine("arr[j] " + arr[j]);
				// Console.WriteLine(arr[i] - arr[j]);
                if(Math.Abs(arr[i] - arr[j]) == k){
                    totalPairs += 1;
                }
            }
        }
        return totalPairs;

    }

	

}