using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProj
{
    delegate bool PromotionDel(Employee emp);
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experiance { get; set; }

        public static void Pramote(List<Employee> empList, PromotionDel isPramotable)
        {
            foreach(Employee emp in empList)
            {
                if(isPramotable(emp))
                {
                    Console.WriteLine(emp.Name + " is pramoted");
                }
            }
        }
    }
}
