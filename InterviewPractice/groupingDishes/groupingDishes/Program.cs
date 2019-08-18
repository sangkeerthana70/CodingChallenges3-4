using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupingDishes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] dishes = new string[4][];
            dishes[0] = new string[] { "Salad", "Tomato", "Cucumber", "Salad", "Sauce" };
            dishes[1] = new string[] { "Pizza", "Tomato", "Sausage", "Sauce", "Dough" };
            dishes[2] = new string[] { "Quesadilla", "Chicken", "Cheese", "Sauce" };
            dishes[3] = new string[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" };

            groupingDishes(dishes);
        }

        static string[][] groupingDishes(string[][] dishes)
        {
            string[][] result = new string[][] { };
            Dictionary<string, List<string>> groupOfDishes = new Dictionary<string, List<string>>();

            List<string> dish;

            string firstRowElement;// dish
            string currentElement;// ingredient
            for(int i = 0; i < dishes.Length; i++)
            {
                firstRowElement = dishes[i][0];
                //Console.WriteLine("firstRowElement " + firstRowElement);
                for(int j = 1; j < dishes[i].Length; j++)
                {
                    //Console.WriteLine("dishes[i][j] " + dishes[i][j]);
                    currentElement = dishes[i][j];
                    //Console.WriteLine("currentElement " + currentElement);
                    if (groupOfDishes.ContainsKey(currentElement))
                    {
                        groupOfDishes[currentElement].Add(firstRowElement);
                    }
                    else
                    {
                        dish = new List<string>();
                        dish.Add(firstRowElement);
                        groupOfDishes.Add(currentElement, dish);
                    }
                }

                foreach(KeyValuePair <string, List<string>> dicResult in groupOfDishes)
                {
                    foreach (string value in dicResult.Value)
                    {
                        Console.WriteLine("key = {0}, value = {1} ", dicResult.Key, value);
                    }
                }
            }

            return result;
        }
 
    }

    
}
