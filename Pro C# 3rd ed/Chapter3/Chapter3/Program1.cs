using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3
{
    class Program1 : BaseClass
    {
        internal static void inheritance()
        {
            Console.Clear();

            BaseClass b = new BaseClass();
            Program1 p = new Program1();

            b.print();
            p.print();

            Console.ReadLine();
            return;
        }
        public Program1()
        {
            Console.WriteLine("Inheritance class constructor");
        }
        public void print()
        {
            Console.WriteLine("Inheritance class print()");
        }
    }
}
