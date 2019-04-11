using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 2, 3, 4 };
            bool result = containsDuplicates(arr);
            Console.WriteLine(result);
        }

        public static bool containsDuplicates(int[] a)
        {
            bool result = false;
            Array.Sort(a);
            for(int i = 0; i < a.Length -1; i++)
            {
                if (a[i] == a[i + 1])
                    return true;
            }        
            return false;
        }

    }
}
