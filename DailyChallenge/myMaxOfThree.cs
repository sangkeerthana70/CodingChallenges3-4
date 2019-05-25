//Find the largest number from the given three integers.


int myMaxOfThree(int a, int b, int c) {
    int max = a;
    if(a > b && a > c){
        max = a;
    }
    if(b > a && b > c){
        max = b;
    }
    else 
        max = c;
    return max;
}
