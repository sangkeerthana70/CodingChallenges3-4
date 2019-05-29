/*
Implement an algorithm that can output a substring of the given string given a starting point and a length.

Example

For inputString = "abcde", start = 2, and length = 3, the output should be
mySubstringByLength(inputString, start, length) = "cde".
*/

string mySubstringByLength(string inputString, int start, int length) {
     string output = "";
    for(int i = 0; i < inputString.Length; i++){
       output = inputString.Substring(start, length);
    }
    return output;
}
