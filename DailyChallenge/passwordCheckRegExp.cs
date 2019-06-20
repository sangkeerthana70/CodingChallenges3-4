/*
A password is complex enough, if it meets all of the following conditions:

its length is at least 5 characters;
it contains at least one capital letter;
it contains at least one small letter;
it contains at least one digit.
Determine whether a given password is complex enough.

Example

For inputString = "my.Password123", the output should be
passwordCheckRegExp(inputString) = true;
For inputString = "my.password123", the output should be
passwordCheckRegExp(inputString) = false.
*/




bool passwordCheckRegExp(string inputString) {

    bool upperFound = false;
    bool lowerFound = false;
    bool digitFound = false;
    
    if(inputString.Length <5)
        return false;
    
    for(int i = 0; i < inputString.Length; i++)
    {
        if(char.IsUpper(inputString[i]))
           upperFound = true;
        if(char.IsLower(inputString[i]))
            lowerFound = true;
        if(char.IsDigit(inputString[i]))
           digitFound = true;
           
        if(upperFound && lowerFound && digitFound)
       {
            return true;
       }
    }
           
    return false;
}
