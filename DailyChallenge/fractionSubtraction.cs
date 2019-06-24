/*
Implement a function that can subtract two reduced fractions and produce a new one.

Example

For a = [7, 10] and b = [3, 10], the output should be
fractionSubtraction(a, b) = [2, 5].

7/10 - 3/10 = 4/10 = 2/5, so the answer is [2, 5].

*/



int[] fractionSubtraction(int[] a, int[] b) {

   int[] result = new int[2];
   if(a[1] == b[1])
   {
      result[0] = a[0] - b[0];
      result[1] = a[1];
   }
   
   // if denominators are not the same.
   if(a[1] != b[1])
   {
	   // if both denominators are different and are multiples of each other Eg:2/5 and 1/10
      if(a[1] % b[1] == 0 || b[1] % a[1] == 0)
      {
         int maxDenominator = Math.Max(a[1], b[1]);
         int minDenominator = Math.Min(a[1], b[1]);
         int numToMultiply = maxDenominator / minDenominator;
         
         result[0] = a[0] * numToMultiply - b[0];
         result[1] = a[1] * numToMultiply;
      }
      // if both denominators are different and not multiples of each other Eg:2/4 and 5/9
      else
      {
         int firstDenominator = a[1];
          int secondDenominator = b[1];
          a[0] *= secondDenominator;
          a[1] *= secondDenominator;
          b[0] *= firstDenominator;
          b[1] *= firstDenominator;
          //Console.WriteLine("first num: {0} first den: {1} / sec num: {2} sec denL {3}", a[0], a[1], b[0], b[1]);
          result[0] = a[0] - b[0];
          result[1] = b[1];

      }
   }
   
   // reduce the fraction furthur Eg: 4/ 10 can be reduced to 2/ 5
   if(result[0] % 2 == 0 && result[1] % 2 == 0)
   {
      result[0] /= 2;
      result[1] /= 2;
   }
   
   else if (result[1] % result[0] == 0)
   {
       result[1] /= result[0];
       result[0] /= result[0];
   }

   return result;
}