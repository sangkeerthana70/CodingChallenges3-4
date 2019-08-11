int[] longestUncorruptedSegment(int[] sourceArray, int[] destinationArray) {

    int[] result = new int[2];
    result[0] = 0;
    result[1] = 0;
    
    int currIndex = 0;
    int currLength = 0;
    
    
    for(int i = 0; i < sourceArray.Length ; i++)
    {
        if(sourceArray[i] == destinationArray[i]){
            if(currLength == 0)
            {
                currIndex = i;
               

            }
            
            currLength += 1;
            if(currLength > result[0]){
                result[0] = currLength;
                result[1] = currIndex;
            }
                
        }
        else
        {
            currLength = 0;
           
        }
        
    }
    
    return result;
}
