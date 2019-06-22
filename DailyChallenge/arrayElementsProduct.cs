/*
Given an array of integers, find the product of its elements.

Example

For inputArray = [1, 3, 2, 10], the output should be
arrayElementsProduct(inputArray) = 60.
*/

int arrayElementsProduct(int[] inputArray) {

    int product = 1;
    for(int index = 0; index < inputArray.Length; index++){
        product *= inputArray[index];
        
    }
    return product;
    
}