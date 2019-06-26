
/*
Given an integer n, find the number of trailing zeros in the decimal representation of n! (the exclamation mark means factorial).

Example

For n = 10, the output should be
factorialTrailingZeros(n) = 2.
10! = 3628800, it has 2 trailing zeros.
*/



int factorialTrailingZeros(int n) {
	
	     //divide the number by 5 to check how many trailing zeros are in the factorial of that number
    	 int count = 0;
         int divider = 5;
		 while ((n/divider) > 0) {
            count += n/divider;
            divider = divider * 5;
         }
		return count;
    
}

