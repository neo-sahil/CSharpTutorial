using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class re
    {
        public void print(int n)
        {
            if (n == 0)
                return;

            Console.WriteLine("Hello!");

            print(n - 1);

        }
    }
}
