/*
Given an integer n, return the largest number that contains exactly n digits.
*/


int largestNumber(int n) {
    Console.WriteLine(Convert.ToInt32(Math.Pow(10, n) -1));
    return Convert.ToInt32(Math.Pow(10, n) -1);
}
