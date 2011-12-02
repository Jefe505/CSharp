using System;

namespace Chapter1
{
    class Program3
    {
        /// <summary>
        /// A method for testing enumerations
        /// </summary>
        enum enumeration {Sträng = 1, Två = 1, Karr = 3};

        internal static void enums2 ()
        {
            Console.WriteLine(enumeration.Två.ToString());
            Console.WriteLine((int) enumeration.Sträng);

            print();

            return;
        }

        /// <summary>
        /// Testing how to print the values of an enumeration
        /// </summary>
        private static void print()
        {
            foreach (enumeration e in Enum.GetValues(typeof(enumeration)))
            {
                Console.WriteLine(e);
            }
        }
    }
}
