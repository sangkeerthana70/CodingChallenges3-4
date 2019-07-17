bool areSimilarNumbers(int a, int b, int divisor) {

    if((a % divisor == 0) && (b % divisor == 0))
        return true;
    else if(a % divisor == 0 || b % divisor != 0)
        return true;
    
   // else if(a % divisor != 0 || b % divisor == 0)
        //return true;

    return false;
}
