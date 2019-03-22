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

                // calculate ideal delivery time
                double idealDeliveryTime = order_ready_time + order_wait_time;

                // delivery window should be between order_ready_time and idealDeliveryTime
                if ((totalTime < order_ready_time) || (totalTime > idealDeliveryTime))
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
//Console Output:
//totalTime: 17.5 =====> (totalTime < order_ready_time) hence returns false
//idealDeliveryTime: 35
//totalTime: 30 =======> (totalTime is between 20 and 35(20 +15) hence returns true
//idealDeliveryTime: 35