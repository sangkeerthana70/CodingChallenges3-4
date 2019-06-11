/*
Given an integer index n, find the nth Fibonacci number.
Note: Write a solution with O(n) complexity and O(1) additional memory.
*/

int fibonacciNumber(int n) {
   if(n <= 1)
      return n;
   else
      return fibonacciNumber(n-1) + fibonacciNumber(n-2);
}
