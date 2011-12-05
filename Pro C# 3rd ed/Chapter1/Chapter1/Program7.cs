#define DEBUG
//#define PRODEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1
{
    class Program7
    {
        /// <summary>
        /// A method for testing out the preprocessor.
        /// </summary>
        internal static void preprocessor()
        {
            Console.Clear();
            Console.WriteLine("Class started.");
#if PRODEBUG
            Console.WriteLine("Prodebuging enabled.");
#elif DEBUG
            Console.WriteLine("Debuging enabled.");
//#error "Haven't specified anything for PRODEBUG, remove before compiling."
#endif
            Console.WriteLine("Class endning");
            Console.ReadLine();

            Console.ReadLine();
            return;
        }
    }
}
