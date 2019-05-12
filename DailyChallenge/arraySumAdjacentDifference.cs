int arraySumAdjacentDifference(int[] inputArray) {

    int arrSum = 0;
    for(int i = 0; i < inputArray.Length -1; i++){
        arrSum += Math.Abs(inputArray[i] - inputArray[i+1]);
    }
    return arrSum;
}
