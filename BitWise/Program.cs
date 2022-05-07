﻿using System;

namespace BitWise
{
    class Program
    {
        static void UniqueNumbers2(int[] arr, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {

                // Xor  all the elements of the array
                // all the elements occurring twice will
                // cancel out each other remaining
                // two unique numbers will be xored
                sum = (sum ^ arr[i]);
            }

            // Bitwise & the sum with it's 2's Complement
            // Bitwise & will give us the sum containing
            // only the rightmost set bit
            sum = (sum & -sum);

            // sum1 and sum2 will contains 2 unique
            // elements  initialized with 0 box
            // number xored with 0 is number itself
            int sum1 = 0;
            int sum2 = 0;

            // Traversing the array again
            for (int i = 0; i < arr.Length; i++)
            {

                // Bitwise & the arr[i] with the sum
                // Two possibilities either result == 0
                // or result > 0
                if ((arr[i] & sum) > 0)
                {

                    // If result > 0 then arr[i] xored
                    // with the sum1
                    sum1 = (sum1 ^ arr[i]);
                }
                else
                {

                    // If result == 0 then arr[i]
                    // xored with sum2
                    sum2 = (sum2 ^ arr[i]);
                }
            }

            // Print the the two unique numbers
            Console.WriteLine("The non-repeating "
                              + "elements are " + sum1 + " and "
                              + sum2);
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 1, 4, 3, 5, 1, 2};
            int n = arr.Length;

            UniqueNumbers2(arr, n);
            Console.WriteLine("Hello World!");
        }
    }
}
