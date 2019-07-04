/*

We need to turn a mixed fraction into an improper reduced fraction
Example

For a = [3, 1, 2], the output should be
mixedFractionToImproper(a) = [7, 2].

Explanation: 3 + 1/2 = 7/2.
*/


int[] mixedFractionToImproper(int[] a) {

        int [] fraction = new int[2];
  
        for(int num = 0; num < a.Length; num++){               
             fraction[0] = (a[0] * a[2]) + a[1];               
             fraction[1] = a[2];              
        }        
    return fraction;
}
