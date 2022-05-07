using System;
using System.Collections.Generic;

namespace DelegateProj
{
    public delegate void HelloPointer(string str);
    class Program
    {
        public static void Hello(string str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            //HelloPointer del = new HelloPointer(Hello);
            //del("Hello from Delegate");

            List<Employee> empList = new List<Employee>()
            {
                new Employee(){Id=1, Name = "Sahil",Experiance=5},
                new Employee(){Id=2, Name = "Mary",Experiance=10},
                new Employee(){Id=3, Name = "Kittu",Experiance=2},
                new Employee(){Id=4, Name = "Jhon",Experiance=3},
                new Employee(){Id=5, Name = "Ezio",Experiance=6},
            };

            //this is by creating instance of a delegate and a function
            //PromotionDel del = new PromotionDel(CheckPromotion);
            //Employee.Pramote(empList,del);

            //this is by lamda expression
            Employee.Pramote(empList, emp => emp.Experiance > 5);

            ////muticast deletgate part 1
            //MultiDelgate del1, del2, del3, del4;
            //del1 = new MultiDelgate(Multi.Method1);
            //del2 = new MultiDelgate(Multi.Method2);
            //del3 = new MultiDelgate(Multi.Method3);
            //del4 = del1 + del2 + del3;
            //del4();
            //Console.WriteLine();
            //del4 += del2;
            //del4();


            ////multicast deletgate part 2
            //MultiDelgate del1 = new MultiDelgate(Multi.Method1);
            //del1 += Multi.Method2;
            //del1 += Multi.Method3;

            //del1();

            TestModifires testObj = new TestModifires();
            testObj.SamplePrint();
        }

        public static  bool CheckPromotion(Employee emp)
        {
            if(emp.Experiance >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
