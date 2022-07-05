using System;

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

        static int findUnique(int[] a, int n, int k)
        {
            // Create a count array to store count of
            // numbers that have a particular bit set.
            // count[i] stores count of array elements
            // with i-th bit set.
            byte sizeof_int = 4;
            int INT_SIZE = 8 * sizeof_int;
            int[] count = new int[INT_SIZE];

            // AND(bitwise) each element of the array
            // with each set digit (one at a time)
            // to get the count of set bits at each
            // position
            for (int i = 0; i < INT_SIZE; i++)
                for (int j = 0; j < n; j++)
                    if ((a[j] & (1 << i)) != 0)
                        count[i] += 1;

            // Now consider all bits whose count is
            // not multiple of k to form the required
            // number.
            int res = 0;
            for (int i = 0; i < INT_SIZE; i++)
                res += (count[i] % k) * (1 << i);
            return res;
        }

        static void Sorting(int[] a)
        {
            int k = 0;

            for(int i = 0; i < a.Length; i++)
            {
                if((a[i] & 1) == 0)
                {
                    int x = a[i];
                    for(int j = i; j > k; j--)
                    {
                        a[j] = a[j - 1];
                    }
                    a[k] = x;
                    k++;
                }
            }

            var z = 0;
            for (int i = 0; i < k; i++)
            {
                if ((a[i] % 5) == 0)
                {
                    int x = a[i];
                    for (int j = i; j > z; j--)
                    {
                        a[j] = a[j - 1];
                    }
                    a[z] = x;
                    z++;
                }
            }

            for (int i = 0; i < z; i++)
            {
                for (int j = i+1; j < z; j++)
                {
                    a[i] = a[i] ^ a[j];
                    a[j] = a[i] ^ a[j];
                    a[i] = a[i] ^ a[j];
                }    
            }

            foreach (int a1 in a)
            {
                Console.Write("{0} ", a1);
            }
        }
        static void Main(string[] args)
        {
            //int[] arr = { 5, 4, 1, 4, 3, 5, 1, 2};
            int[] arr = { 2, 3, 13, 9, 11,20, 7, 11, 10, 6 , 30 ,35 };
            int n = arr.Length;

            // UniqueNumbers2(arr, n);

            //int[] a = { 6, 2, 5, 2, 2, 6, 6 };
            //int n = a.Length;
            //int k = 3;
            //Console.WriteLine(findUnique(a, n, k));

            Sorting(arr);
            
        }
    }
}
