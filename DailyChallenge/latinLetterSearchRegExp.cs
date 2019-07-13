/*
	Determine if the given string contains at least one English letter.

	Example

	For input = "a_ _2", the output should be
	latinLettersSearchRegExp(input) = true;
*/

bool latinLettersSearchRegExp(string input) {

    for(int i = 0; i < input.Length; i++)
    {
        if(char.IsLetter(input[i]))
           return true;
    }
    return false;
}
