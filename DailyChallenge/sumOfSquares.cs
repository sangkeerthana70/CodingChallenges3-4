/*
Find the sum of squares of all integers from 1 up to and including given N.

Example

For n = 5, the output should be
sumOfSquares(n) = 55.
*/

int sumOfSquares(int n) {

    int sumSquares = 0;
    for(int i = 1; i <= n; i++)
    {
        sumSquares += i * i;
    }
    return sumSquares;
}
