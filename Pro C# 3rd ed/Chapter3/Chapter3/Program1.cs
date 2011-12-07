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

            Console.WriteLine("BaseClass.math: {0}", b.math(2, 3));
            Console.WriteLine("Inheritance.math: {0}", p.math(2, 3));

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

        public override int math(int a, int b)
        {
            Console.WriteLine("Overriding baseclass.math to multiply");
            return a*b;
        }
    }
}
