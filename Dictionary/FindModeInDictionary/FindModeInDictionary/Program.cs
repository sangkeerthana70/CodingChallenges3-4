using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindModeInDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 3, 4, 5, 3, 7, 7, 9, 4, 3, 10, 7, 7 };
            FindModeInDictionary(numbers);
        }

        public static int FindModeInDictionary(List<int> num)
        {
            //Calculate mode in a list of numbers
            // mode refers to the  most-common or most-frequently occurring value in a series of data.
            // pseudocode
            // define an empty dictionary<int, int>
            // given a list of numbers set up a for loop to go through all the numbers.
            // eg:{2,3,4,5,3,7,7,9,4,3,10}
            // if current element in the list exists in the dictionary, update the value of the key by incrementing it.
            // else add the current element to the dictionary set value = 1;
            // at the end of for loop dictionary looks like below 
            // { 2:1, 3:3, 4:2, 5:1, 7:4, 9:1, 10:1}

            Dictionary<int, int> numDict = new Dictionary<int, int>();
            int maxValue = int.MinValue;
            int refKey = 0;
            for (var i = 0; i < num.Count; i++)
            {
                // if the key already exists
                if(numDict.ContainsKey(num[i]))
                {
                    numDict[num[i]] +=  1;
                }
                else
                {
                    numDict.Add(num[i], 1);
                }

            }
            // Console.WriteLine("Key = {0} value = {1}", numDict.Keys, numDict.Values);

            
            foreach(var number in numDict)
            {
                Console.WriteLine("Key = {0} value = {1}", number.Key, number.Value);
                // find the maximum value in the dictionary
                if(number.Value > maxValue)
                {
                    maxValue = number.Value;
                    refKey = number.Key;
                    //Console.WriteLine("Key: " + refKey);

                }
                
            }
            // return the number with the most occurrance
            Console.WriteLine("The mode of the list of numbers = {0}  " , refKey);
            return refKey;
        }
    }
}
