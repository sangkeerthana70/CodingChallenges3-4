/*
It is believed that primeval humans, as far as counting their cattle was concerned, distinguished only among "one", "two", and "many". Given the number of sheep an imaginary primeval man is looking at, return a string he would use to describe that quantity.

Example

For n = 20, the output should be
oneTwoMany(n) = "many".
*/



string oneTwoMany(int n) {
   if(n == 1)
      return "one";
   else if(n == 2)
      return "two";
   else
      return "many";
    
}
