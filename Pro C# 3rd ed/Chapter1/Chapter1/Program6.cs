using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1
{
    class Program6
    {
        /// <summary>
        /// A method for testing how you can manipulate the output of strings.
        /// </summary>
        internal static void formatingStrings()
        {
            decimal i = 948.1993m, j = 3.390490209m;
            double k = 313131.01001;
            int a=13, b=2;

            Console.WriteLine("{0:C2}", i);
            Console.WriteLine("{0:F20}", j);
            Console.WriteLine("{0:E30}", i + j);
            Console.WriteLine("{0:G2}", i - j);
            Console.WriteLine("{0:X2}", a + b);
            Console.WriteLine("{0:#.000}", k);
            return;
        }
    }
}
