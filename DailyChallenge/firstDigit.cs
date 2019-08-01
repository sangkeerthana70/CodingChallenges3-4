/*
Find the leftmost digit that occurs in a given string.

Example

For inputString = "var_1__Int", the output should be
firstDigit(inputString) = '1';
For inputString = "q2q-q", the output should be
firstDigit(inputString) = '2';
*/

char firstDigit(string inputString) {
    
    int i = 0;
    for(i = 0; i < inputString.Length; i++)
    {
        if(char.IsDigit(inputString[i])){
            break;
        }
    }
    return inputString[i];
           
}
