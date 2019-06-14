/*
Given a number and a range, find the largest integer within the given range that's divisible by the given number.

Example

For left = 1, right = 10, and divisor = 3, the output should be
maxDivisor(left, right, divisor) = 9.

The largest integer divisible by 3 in range [1, 10] is 9.
*/


int maxDivisor(int left, int right, int divisor) {

    int maxNumber = 0;
    for(int i = left; i < right; i++){
        if(i % divisor == 0){
            if(i > maxNumber){
                maxNumber = i;                
            }           
        }
		
    }
    return maxNumber;
    
}
