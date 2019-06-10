using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedListsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> list = new List<List<int>>();

            for (int i = 0; i < 10; i++)
            {
                List<int> subList = new List<int>();
                for (int j = 0; j < 5; j++)
                {
                    subList.Add(1);
                    
                }
                list.Add(subList);
                
            }
            Display(list);

        }

        static void Display(List<List<int>> list)
        {
            Console.WriteLine("display elements in a sublist");
            foreach (var sublist in list)
            {
                foreach (var value in sublist)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            //
            // Display element at 3, 3.
            //
            if (list.Count > 3 &&
                list[3].Count > 3)
            {
                Console.WriteLine("Element at 3, 3:");
                Console.WriteLine(list[3][3]);
            }
            //
            // Display total count.
            //
            int count = 0;
            foreach (var sublist in list)
            {
                count += sublist.Count;
            }
            Console.WriteLine("Count:");
            Console.WriteLine(count);
        }
    }
}
