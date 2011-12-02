using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1
{
    class Program4
    {
        /// <summary>
        /// Method for testng out arrays and printing with both a do-while-loop and foreach
        /// </summary>
        internal static void arrays()
        {
            int[] i = new int[4] { 1, 2, 3, 4 };
            string[] s = new string[3] { "Ett", "Två", "Tre" };
            int k = 0;

            do
            {
                Console.WriteLine("i [" + k + "] = " + i[k]);
                k++;
            } while (k < i.Length);

            foreach (string st in s)
                Console.WriteLine(st);

            return;
        }
    }
}
