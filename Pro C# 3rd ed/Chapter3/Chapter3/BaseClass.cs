using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3
{
    abstract public class AbstractBaseClass
    {
        abstract public void print();
        abstract public int math(int a, int b);
    }
    public class BaseClass : AbstractBaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass constructor");
        }

        public override void print()
        {
            Console.WriteLine("BaseClass print()");
        }

        public override int math(int a, int b)
        {
            return a + b;
        }
    }
}
