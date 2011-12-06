using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            int test;
            string answer;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Which test to run?");
                Console.WriteLine("1 Inheritance?\t");
                Console.WriteLine("E Exit?");

                answer = Console.ReadLine();

                if (answer.Equals("e") || answer.Equals("E"))
                    return;
                try
                {
                    test = int.Parse(answer);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Don't understand option.");
                    continue;
                }
                switch (test)
                {
                    case 1:
                        Program1.inheritance();
                        break;
                }
            }
        }
    }
}
