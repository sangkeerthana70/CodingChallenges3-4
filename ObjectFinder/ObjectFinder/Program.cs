using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Object Finder

            Given an array of objects All with the same keys and A key and value. Return the index of the object that has that key and value.

            ex:[{name:Cliff age:32} {name:John age:25} {name:Andy age:32} {name:Mary age:21} {name:Sally age:25}]

            Age:25 should return output as 1.
            if using array or list of dictionary return index of dictionary, try using bracket notation[""]

            ==================================================================================
            Additional challenge
            1.Return all integers that match the index in an array[1,4]

            2.With the key given find the object where any key matches
            Ex:{a:Foo b:bar} {a:duh b:gif} {a:hi b:Foo} {
            Key:Foo return [0,2]
            */

            /*
            var data = new Dictionary<string, int>
            {
                {"Cliff",32 },
                {"John",25 },
                {"Andy",32 },
                {"Mary",21 },
                {"Sally",25 },
            };
            */
           
            // Declare a list of Key value pairs
            var list = new List<KeyValuePair<string, int>>();
            list.Add(new KeyValuePair<string, int>("Cliff", 32));
            list.Add(new KeyValuePair<string, int>("John", 25));
            list.Add(new KeyValuePair<string, int>("Andy", 32));
            list.Add(new KeyValuePair<string, int>("Mary", 21));
            list.Add(new KeyValuePair<string, int>("Sally", 25));

            foreach(var keyvalue in list)
            {
                Console.WriteLine("keyVal " + keyvalue);
               
            }

            int result = GetMatchingValueIndex(list, 25);
            Console.WriteLine("result " + result);

            //additional challenge
            int[] indices = GetMatchingValueIndices(list, 25);


        }

        static int GetMatchingValueIndex(List<KeyValuePair<string, int>> data, int value)
        {
            KeyValuePair<string, int> pair;
            for(int i = 0; i < data.Count; i++)
            {
                pair = data[i];
                Console.WriteLine("pair " + pair);
                if (pair.Value == value)
                    return i;
            }
            return -1;
            
        }

        static int[] GetMatchingValueIndices(List<KeyValuePair<string, int>> data, int value)
        {
            KeyValuePair<string, int> pair;
            int i = 0;
            List<int> matchingIndices = new List<int>();
            foreach(KeyValuePair<string, int> singleData in data)
            {
                
                pair = singleData;
                if(pair.Value == value)
                {
                    matchingIndices.Add(i);
                }
                i++;
            }
            Console.WriteLine("matchingIndices " + String.Join(",", matchingIndices));
            return matchingIndices.ToArray();
        }
        
    }
}
