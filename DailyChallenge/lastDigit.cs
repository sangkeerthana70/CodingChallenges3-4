/*
For given integers a and b, find the last digit of ab.

Example

For a = 2 and b = 5, the output should be
lastDigit(a, b) = 2.

Explanation: 25 = 32.
*/



int lastDigit(int a, int b) {

   double power = Math.Pow(a, b);
    //Console.WriteLine(power);
	int last = (int)power % 10;
	//Console.WriteLine(last);
	return last;
}
