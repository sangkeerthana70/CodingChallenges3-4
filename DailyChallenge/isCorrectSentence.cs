/*
A string is said to be a correct sentence if it starts with the capital letter and ends with a full stop (.).

Given a string, check whether it represents a correct sentence.

Example

For inputString = "This is a correct sentence.", the output should be
isCorrectSentence(inputString) = true; */


bool isCorrectSentence(string inputString) {

    if(char.IsUpper(inputString[0])  && inputString.EndsWith("."))
    {
        return true;
    }
    return false;
                
}
