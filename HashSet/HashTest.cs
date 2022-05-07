using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class HashTest
    {
        public bool isDistinct(int[] arr)
        {
            HashSet<int> hash = new HashSet<int>(arr);

            if (arr.Length == hash.Count)
                return true;
            else
                return false;
        }

        public void isHash()
        {
            int[] a = { 1, 2,5,8,0,4};

            if (isDistinct(a))
            {
                Console.WriteLine("Array is distinct");
            }
            else
            {
                Console.WriteLine("Array is not distinct");
            }
        }
    }
}
