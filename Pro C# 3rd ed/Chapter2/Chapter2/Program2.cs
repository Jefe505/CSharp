//#define TEST

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{
    class Program2
    {
        internal static void parameters()
        {
            Console.Clear();
            int x = 0;
            int[] xs = { 1, 2, 3, 4, 5 };
            string s = "Hej";

            Console.WriteLine("x = {0}", x);
#if !TEST
            foreach (int y in xs)
                Console.WriteLine("xs = {0}", y);
            Console.WriteLine("s = {0}", s);
#endif
            Console.WriteLine("\n===== Calling function =====");
            function(x, xs, s);

            Console.WriteLine("\n===== Writing from main again.=====");
            Console.WriteLine("x = {0}", x);
#if !TEST
            foreach (int y in xs)
                Console.WriteLine("xs = {0}", y);
            Console.WriteLine("s = {0}", s);
#endif
            Console.WriteLine("\n===== Calling refFunction =====");
            refFunction(ref x, ref xs, ref s);

            Console.WriteLine("\n=====Writing from main again.=====");
            Console.WriteLine("x = {0}", x);
            foreach (int y in xs)
                Console.WriteLine("xs = {0}", y);
            Console.WriteLine("s = {0}", s);

            Console.ReadLine();
            return;
        }

        private static void function(int x, int[] xs, string s)
        {
            x =+ 1;
            Console.WriteLine("x in funtion = {0}", x);
#if !TEST
            xs[2] = 0;
            Console.WriteLine("xs[2] in function = {0}", xs[2]);
            s = s + " hej";
            Console.WriteLine("s in function = {0}", s);
#endif
            return;
        }

        private static void refFunction(ref int x, ref int[] xs, ref string s)
        {
            x = +2;
            Console.WriteLine("x in funtion = {0}", x);
#if !TEST
            xs[2] = 2;
            Console.WriteLine("xs[2] in function = {0}", xs[2]);
            s = s + " svej";
            Console.WriteLine("s in function = {0}", s);
#endif
            return;
        }
    }
}
