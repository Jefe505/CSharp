using System;

namespace Chapter1
{
    class Program1
    {
        /// <summary>
        /// Method to test what variables are available in C# and print them.
        /// </summary>
        internal static void Variables()
        {
            string s = "Hej";
            string s2 = @"Hejsan\hopp
san";
            int i = 1;
            double d = 1.1;
            byte b = 0;
            bool bo = false;
            int[] array = new int[3] {1, 2, 3};

            Console.WriteLine("s = " + s);
            Console.WriteLine("s2 = " + s2);
            Console.WriteLine("i = " + i);
            Console.WriteLine("d = " + d);
            Console.WriteLine("b = " + b);
            Console.WriteLine("bo = " + bo);
            Console.WriteLine("array = " + array[0] + ", " + array[1] + ", " + array[2]);

            return;
        }
    }
}