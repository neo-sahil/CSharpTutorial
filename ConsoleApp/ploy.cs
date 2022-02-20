using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class playA
    {
        public virtual void print()
        {
            Console.WriteLine("This is PlayA");
        }
    }

    class playB: playA
    {
        public override void print()
        {
            Console.WriteLine("This is PlayB");
        }
    }

    class playC : playB
    {
        public override void print()
        {
            Console.WriteLine("This is PlayC");
        }
    }
}

