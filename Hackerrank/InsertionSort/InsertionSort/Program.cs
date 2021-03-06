﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] arr = new int[] { 2, 4, 6, 8, 3};
            insertionSort1(n, arr);
        }
        
        // Complete the insertionSort1 function below.
        static void insertionSort1(int n, int[] arr)
        {
            int lastElem = arr[arr.Length-1];
                           
            for (int i = arr.Length - 2; i >= 0; i--)
            { 
                int currIndex = i; 
                if (arr[i] < lastElem)
                {
                    arr[currIndex + 1] = lastElem;
  
                    foreach (int num in arr)
                    {
                        Console.Write(" " + num);
                    }
                }
                else
                {
                    arr[i + 1] = arr[i];
                    foreach (int num in arr)
                    {
                        Console.Write(" " + num);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

