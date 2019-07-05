using System;
					
public class Program
{
	public static void Main()
	{
		int[] arr = { 3, 5, 7, 12, 13, 14, 21, 23, 23, 23, 23, 29, 40, 56 };
		//int[] arr = { 0, 1, 2, 4, 6, 5, 3 };
		int result = findMedian(arr);		
		Console.WriteLine(result);
	}
	/*
	The median of a list of numbers is essentially it's middle element after sorting. The same number of elements occur after it as before. Given a list of numbers with an odd number of elements, can you find the median?
	For example, the median of arr = [1, 2, 3, 4, 5 ] is 3, the middle element in the sorted array.
	
	*/
	// Complete the findMedian function below.
    static int findMedian(int[] arr) {
        Array.Sort(arr);
		
        int length = arr.Length;
		
        int median = 0;
        for(int i = 0; i < length -1; i++)
        {
            if(length % 2 == 0)// if array length is even
            {
				median = (arr [(length/2) -1] +  arr[(length/2) + 1]) / 2 ;                
            }
			else// if array length is odd
			{
				median = arr[length / 2];
			}
        }
		return median;


    }
}