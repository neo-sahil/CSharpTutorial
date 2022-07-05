using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class ListTest
    {
        public void Test()
        {
            Customer customer1 = new Customer()
            {
                FirstName = "Sahil",
                LastName = "Sharma"
            };

            Customer customer2 = new Customer()
            {
                FirstName = "Test2",
                LastName = "Test2Sur"
            };

            Customer customer3 = new Customer()
            {
                FirstName = "Test3",
                LastName = "Test3Sur"
            };

            List<Customer> list = new List<Customer>();

            list.Add(customer1);
            list.Add(customer2);    
            list.Add(customer3);

            //this is containes
            Console.WriteLine(list.Contains(customer1));

            //we use exits function if we want to check on condition
            Console.WriteLine(list.Exists(x => x.FirstName.StartsWith("sa")));

            Console.WriteLine(list.Find(x => x.FirstName.StartsWith("T")).FirstName);

            Console.WriteLine(list.FindLast(x => x.FirstName.StartsWith("T")).FirstName);

            foreach (var item in list.FindAll(x => x.FirstName.StartsWith("T")))
            {
                Console.WriteLine(item.FirstName);
            }

            Console.WriteLine(list.FindIndex(x => x.FirstName.StartsWith("T")));

            Console.WriteLine(list.FindLastIndex(x => x.FirstName.StartsWith("T")));
        }
    }
}
