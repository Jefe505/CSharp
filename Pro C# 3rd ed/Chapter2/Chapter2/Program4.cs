using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{
    class Program4
    {
        internal static void readWrite()
        {
            Console.Clear();

            Prog4Test.Name = "Hello";
            Console.WriteLine("Name: {0}", Prog4Test.Name);

            Prog4Test.Nagging = "Hello";
            Console.WriteLine("Nagging set to 'Hello'");

            Console.WriteLine("Personnumber: {0}", Prog4Test.PersonNr);

            Console.ReadLine();
            return;
        }
    }

    class Prog4Test
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
    }
}
