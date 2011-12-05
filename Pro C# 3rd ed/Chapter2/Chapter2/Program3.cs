using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{
    class Program3
    {
        internal static void overloading()
        {
            Console.Clear();
            string s = "Hej";
            int x = 1;

            printOne(s);
            printOne(s, x);

            Console.ReadLine();
            return;
        }

        private static void printOne(string s)
        {
            Console.WriteLine("printOne; s={0}", s);
        }

        private static void printOne(string s, int x)
        {
            Console.WriteLine("printOne; s={0}, x={1}", s, x);
        }
    }
}
