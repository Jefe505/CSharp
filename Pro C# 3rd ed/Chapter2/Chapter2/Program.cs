using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
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
                Console.WriteLine("1 Objects?\t 2 Refs?");
                Console.WriteLine("3 Overloading?\t 4 ReadWrite?");
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
                        Program1.objects();
                        break;
                    case 2:
                        Program2.parameters();
                        break;
                    case 3:
                        Program3.overloading();
                        break;
                    case 4:
                        Program4.readWrite();
                        break;
                }
            }
        }
    }
}
