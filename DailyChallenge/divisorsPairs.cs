/*
Given array of integers, find the number of sorted pairs formed by its (different) elements such that the second element in the pair is divisible by the first one.

Example

For sequence = [1, 3, 2], the output should be
divisorsPairs(sequence) = 2.

*/







int divisorsPairs(int[] sequence) {

    int pairs = 0;
    for(int i = 0; i < sequence.Length; i++)
    {
        for(int j = i+1; j < sequence.Length; j++)
        {
            if(sequence[j] % sequence[i] == 0)
            {
                pairs += 1;
            }
        }
        
    }
    return pairs;
}
