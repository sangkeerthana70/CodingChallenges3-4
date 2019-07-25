/*
Find the longest string from the given array.

Example

For inputArray = ["a", "ab", "c"], the output should be
longestString(inputArray) = "ab".
*/




string longestString(string[] inputArray) {

    int maxValue = 0;
    string longestString = "";
    for(int i = 0; i < inputArray.Length; i++){
        if(inputArray[i].Length > maxValue){
            maxValue = inputArray[i].Length;
            longestString = inputArray[i];
        }
    }
    
    return longestString;
}
