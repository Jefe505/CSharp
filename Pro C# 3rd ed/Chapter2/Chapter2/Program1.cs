using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{
    class Program1
    {
        internal static void objects()
        {
            Console.Clear();
            Console.WriteLine("Pi is: {0}", objectsTest.getPi());
            Console.WriteLine("Square of 5 is {0}", objectsTest.getSquare(5));

            objectsTest o = new objectsTest();

            o.value = 2;
            Console.WriteLine("Value of o.value: {0}", o.value);
            Console.WriteLine("Square of o.value: {0}", o.getSquare());

            Console.ReadLine();
            return;
        }
    }
    class objectsTest
    {
        public int value;

        public static double getPi()
        {
            return 3.14159265;
        }

        public static int getSquare(int x)
        {
            return x * x;
        }

        internal int getSquare()
        {
            return value * value;
        }
    }
}
