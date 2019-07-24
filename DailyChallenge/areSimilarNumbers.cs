
/*
Call two integers a and b similar if divisor divides both a and b or if it doesn't divide either.

Given integers a, b and divisor, check if a and b are similar.
*/


bool areSimilarNumbers(int a, int b, int divisor) {

    if (((a % divisor == 0) && (b % divisor == 0)) || ((a % divisor != 0) && (b % divisor != 0)))
        return true;
    else
        return false;
}
