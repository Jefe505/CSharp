using System;

///<summary>
///The Chapter1 namespace contains programs that are tests of what is described in chapter 1 of Professional C#, 3:d edition.
///</summary>
namespace Chapter1
{
    class Program
    {
        /// <summary>
        /// This is the main method of the chapter 1.
        /// The loop of this method runs for the purpose of trying out all the tests of the Chapter1 namespace.
        /// </summary>
        static void Main()
        {
            ///<member>
            ///show = the testprogram to run, parsed from answer
            ///answer = the text the user writes in the cmd
            ///</member>
            int show;
            string answer;

            while (true)
            {
                Console.WriteLine("Which part to show? ");
                Console.WriteLine("1 Variables? \t\t 2 Loops?");
                Console.WriteLine("3 Enumerations? \t 4 Arrays?");
                Console.WriteLine("5 Structs? \t\t 6 Formating strings?");
                Console.WriteLine("7 Preprocessor? \t");
                Console.WriteLine("E Exit?");

                answer = Console.ReadLine();

                if (answer.Equals("E") || answer.Equals("e"))
                    return;
                try
                {
                    show = int.Parse(answer);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Don't understand option.");
                    continue;
                }

                switch (int.Parse(answer))
                {
                    case 1:
                        Program1.Variables();
                        break;
                    case 2:
                        Program2.loops();
                        break;
                    case 3:
                        Program3.enums2();
                        break;
                    case 4:
                        Program4.arrays();
                        break;
                    case 5:
                        Program5.structs();
                        break;
                    case 6:
                        Program6.formatingStrings();
                        break;
                    case 7:
                        Program7.preprocessor();
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
