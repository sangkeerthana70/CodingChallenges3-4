
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
    
    bool result = true;
    for(int i = 0; i < inputString.Length; i++)
    {
        if(char.IsLetter(inputString[i]))
        {
            if(i == inputString.Length -1){
                break;
            }
            
           if(char.IsLower(inputString[i]) && char.IsLower(inputString[i+1]) ||                         
		   (char.IsUpper(inputString[i]) && char.IsUpper(inputString[i+1])))           
           {
               result = false;
           }
        }
        else 
        {
            result = false;
        }
		
    }
    return result;
}

