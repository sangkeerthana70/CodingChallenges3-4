int maxDivisor(int left, int right, int divisor) {

    int Divisor = 0;
    for(int i = left; i < right; i++){
        if(i % divisor == 0){
            if(i > Divisor){
                Divisor = i;
                Console.WriteLine(i);
            }
            
        }
		
    }
    return Divisor;
    
}
