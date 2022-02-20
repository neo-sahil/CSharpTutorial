using System;

namespace ConsoleApp
{
    public abstract class AbsClasss
    {
        public AbsClasss(int a)
        {
            PrintConst(a);
        }

        public void PrintConst(int a)
        {
            Console.WriteLine("Constructer colled!! {0}",a);
        }
        public abstract void Print();
    }

    public class Test:AbsClasss
    {
        public Test(int a):base(a)
        {

        }

        public override void Print()
        {
            Console.WriteLine("Abstract print method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Test obj = new Test(12);
            //obj.Print();
            //Console.WriteLine("Hello World!");

            playA obj1 = new playC();
            playB obj2 = new playC();
            playC obj3 = new playC();

            obj1.print();
            obj2.print();
            obj3.print();
        }
    }
}
