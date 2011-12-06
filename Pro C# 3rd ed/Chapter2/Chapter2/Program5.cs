using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{
    class Program5
    {
        static readonly int number = 1;
        internal static void constructor()
        {
            Console.Clear();

            Program5 p1 = new Program5();
            Program5 p2 = new Program5("p2");

            Console.ReadLine();
            return;
        }

        static Program5()
        {
            number = 2;
        }
        private Program5():this("p1")
        {
            Console.WriteLine("Constructor, no text\nNumber: {0}", number);
        }
        private Program5(string text)
        {
            Console.WriteLine("Constructor + {0}\nNumber: {1}", text, number);
        }
    }
}
