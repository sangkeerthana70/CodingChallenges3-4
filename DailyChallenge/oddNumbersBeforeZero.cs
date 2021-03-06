/*
Given an array of integers, count the odd numbers before the first (i.e. leftmost) occurrence of zero.

Example

For sequence = [1, 2, 3, 0, 4, 5, 6, 0, 1], the output should be
oddNumbersBeforeZero(sequence) = 2.
*/

int oddNumbersBeforeZero(int[] sequence) {

    int oddCount = 0;
    for(int i = 0; i < sequence.Length; i++)
    {
        if(sequence[i] != 0)
        {            
            if(sequence[i] % 2 != 0)
            {
                oddCount ++;
            }
        }
        else
            break;
       
    }
    return oddCount;
}
