int houseNumbersSum(int[] inputArray) {

    int sumOfHouseNumbers  = 0;
    for(int i = 0; i < inputArray.Length; i++){
        sumOfHouseNumbers += inputArray[i];
        Console.WriteLine("sum: " + sumOfHouseNumbers);
        if(inputArray[i] == 0){
            break;
        }
    }
    return sumOfHouseNumbers;
}
