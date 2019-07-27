
/*
Let's call a string cool if it is formed only by English letters and no two lowercase and no two uppercase letters are in adjacent positions. Given a string, check if it is cool.

Example

For inputString = "aQwFdA", the output should be
coolString(inputString) = true;
For inputString = "aAA", the output should be
coolString(inputString) = false;
For inputString = "q q", the output should be
coolString(inputString) = false.
*/

bool coolString(string inputString) {
    inputString.Trim(' ');
    for(int i = 0; i < inputString.Length -1; i++)
    {
        if((char.IsLower(inputString[i]) && char.IsLower(inputString[i+1])) ||
            (char.IsUpper(inputString[i]) && char.IsUpper(inputString[i+1])))
           {
               return false;
           }
    }
           
    return true;
}
