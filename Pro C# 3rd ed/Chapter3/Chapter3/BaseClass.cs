using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass constructor");
        }

        public void print()
        {
            Console.WriteLine("BaseClass print()");
        }

        public virtual int math(int a, int b)
        {
            return a + b;
        }
    }
}
