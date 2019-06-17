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
            Dictionary<string, List<string>> dishList = new Dictionary<string, List<string>>();
            string dishName;
            
            List<string> ingredients = new List<string>();

            for (int col = 0; col < dishes[0].Length; col++)
            {              
                    for (int row = 0; row < dishes.Length; row++)
                    {
                    
                        dishName = dishes[col][row];
                        
                        if (dishList.ContainsKey(dishName))
                        {
                        //ingredients = new List<string>();
                            Console.WriteLine("in contains key");
                            ingredients.Add(dishes[row][0]);
                        }
                        else
                        {
                            Console.WriteLine("in adding to list");
                            ingredients = new List<string>();
                            ingredients.Add(dishes[col][row + 1]);
                        
                        }
                        foreach (string ingredient in ingredients)
                        {
                            Console.WriteLine("dishName: " + dishName);
                            Console.WriteLine("list ingredient: " + ingredient);
                        }

                    }
                    foreach(KeyValuePair<string, List<string>> newdishList in dishList)
                    {
                        Console.WriteLine("keyValuePair: " + newdishList);
                    }
                

            }
            
            return result;

        }

    }
}
