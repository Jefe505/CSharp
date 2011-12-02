using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1
{
    class Program2
    {
        /// <summary>
        /// A method for testing loops of various kinds.
        /// </summary>
        internal static void loops()
        {
            int[] i = new int[5] { 1, 2, 3, 4, 5 };
            int j;

            switch (i[0])
            {
                case 1:
                    Console.WriteLine("i[0] = " + i[0]);
                    goto case 2;
                case 2:
                    Console.WriteLine("i[1] = " + i[1]);
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            for (j = 3; j < 4; j++)
            {
                Console.WriteLine("j = " + j);
            }

            j = 0;
            while (true)
            {
                Console.WriteLine("while true");
                if (j == 2)
                    break;
                j++;
            }

            j = 0;
            do
            {
                Console.WriteLine("do while");
                j++;
            } while (j < 3);

            foreach (int temp in i)
            {
                Console.WriteLine(temp);
            }
            return;
        }
    }
}
