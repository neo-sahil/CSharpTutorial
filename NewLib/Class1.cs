using System;

namespace NewLib
{
    public class Class1
    {
        protected void Print()
        {
            Console.WriteLine("This is class library method");
        }
    }

    public class Test : Class1
    {
        public void testMethod()
        {
            Print();
        }
    }

    public class Test2 : Class1
    {
        public void testMethod()
        {
            Print();
            Class1 obj = new Class1();
        }
    }
}
