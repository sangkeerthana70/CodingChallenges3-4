/*
Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.

Example

For inputArray = [2, 4, 1, 0], the output should be
arrayMaximalAdjacentDifference(inputArray) = 3.
*/

int arrayMaximalAdjacentDifference(int[] inputArray) {

    int minValue = Int32.MinValue;
    int difference = 0;
    
    for(int j = 0; j < inputArray.Length -1; j++){
        difference = Math.Abs(inputArray[j] - inputArray[j+1]);
        Console.WriteLine("difference: " + difference);
        if(difference > minValue){
        minValue = difference;
        }
    }
    

   
    return minValue;
}
