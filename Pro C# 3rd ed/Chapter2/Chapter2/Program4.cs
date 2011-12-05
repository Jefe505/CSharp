using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{
    class Program4
    {
        private static string name;
        private static string nagging;
        private static int personNr = 800101;

        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public static int PersonNr
        {
            get
            {
                return personNr;
            }
        }

        public static string Nagging
        {
            set
            {
                nagging = value;
            }
        }

        internal static void readWrite()
        {
            Console.Clear();

            Program4.Name = "Hello";
            Console.WriteLine("Name: {0}", Program4.Name);

            Program4.Nagging = "Hello";
            Console.WriteLine("Nagging set to 'Hej'");

            Console.WriteLine("Personnumber: {0}", Program4.PersonNr);

            Console.ReadLine();
            return;
        }
    }
}
