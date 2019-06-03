/*
Given a string, output its longest prefix which contains only digits.

Example

For inputString = "123aa1", the output should be
longestDigitsPrefix(inputString) = "123".
*/

string longestDigitsPrefix(string inputString) {

    string prefix = "";
    for(int i = 0; i < inputString.Length; i++)
    {   
        if(Char.IsLetter(inputString[i]) || Char.IsWhiteSpace(inputString[i]))
        {
                break;
        }
        
        if(Char.IsDigit(inputString[i]))
        {    
            prefix += inputString[i];
        }
    }
    return prefix;
}
