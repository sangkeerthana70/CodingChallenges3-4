using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] order = new int[] { 200, 20, 15 };
            //int[,] shoppers = new int[2, 3] { { 300, 40, 5 }, { 600, 40, 10 } };
            int[][] shoppers = new int[2][];
            shoppers[0] = new int[] { 300, 40, 5};
            shoppers[1] = new int[] { 600, 40, 10 };


            bool[] result = delivery(order, shoppers);
            //foreach(bool item in result)
            //{
            //    Console.WriteLine(item);
            //}
            string boolArray = String.Join(",", result);
            Console.WriteLine(boolArray);
        }
       

        public static bool[] delivery(int[] order, int[][] shoppers)
        {
            bool[] result = new bool[shoppers.Length];

            int order_Distance = order[0];
            int order_ready_time = order[1];
            int order_wait_time = order[2];

            int index = 0;

            foreach (int[] shopper in shoppers)
            {
                int shopper_distance_from_store = shopper[0];
                int shopper_speed = shopper[1];
                int shopper_shopTime = shopper[2];

                //calculate total time
                double totalTime = Convert.ToDouble(order_Distance + shopper_distance_from_store) / shopper_speed + shopper_shopTime;

                Console.WriteLine("totalTime: " + totalTime);


                // calculate wait time
                double idleTime = order_ready_time + order_wait_time;

                Console.WriteLine("idleTime: " + idleTime);

                if ((totalTime < order_ready_time) || (totalTime > idleTime))
                {
                    result[index] = false;
                }

                else
                {
                    result[index] = true;
                }

                index++;

            }
            return result;

        }
    }
}
