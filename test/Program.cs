using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] str = { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9", "9", "10", "11", "9" };


            //var duplicates = str.GroupBy(x => x)
            // .Where(g => g.Count() > 1)
            // .Select(y => y.Key)
            // .ToList();

            //foreach(string s in duplicates)
            //{
            //    var ss = str.Where(x => x == s).Select(y => y).ToList();
            //    Console.WriteLine(String.Join(", ", ss));
            //}

            //var normal = str.GroupBy(x => x)
            // .Where(g => g.Count()  == 1)
            // .Select(y => y.Key)
            // .ToList();
            //Console.WriteLine(String.Join("<br>", normal));


            //Customer c1 = new Customer();
            //c1.FirstName = "Sahil";
            //c1.LastName = "Sharma";

            //Customer c2 = new Customer();
            //c2.FirstName = "Sahil";
            //c2.LastName = "Sharma";

            //Console.WriteLine(c1 == c2);
            //Console.WriteLine(c2.Equals(c1));

            ListTest lt = new ListTest();
            lt.Test();
        }
    }
}
