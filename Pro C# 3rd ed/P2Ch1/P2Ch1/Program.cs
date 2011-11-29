using System;

namespace Ch1
{
    class P2
    {
        static void Main(string[] args)
        {
            string s = "Hej";
            string s2 = @"Hejsan\hopp
san";
            int i = 1;
            double d = 1.1;
            byte b = 0;
            bool bo = false;
            int[] array = new int[3] { 1, 2, 3 };

            if (bo)
            {
                Console.WriteLine("bo not true");
            }

            switch (i)
            {
                case 1:
                    Console.WriteLine("i = 1");
                    goto case 2;
                case 2:
                    Console.WriteLine("s = " + s + @"s2 =
" + s2);
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            for (int j = 3; j < 4; j++)
            {
                Console.WriteLine(j + " ");
            }

            while (true)
            {
                Console.WriteLine("while");
                break;
            }

            int k = 0;
            do
            {
                Console.WriteLine("do while " + k);
                if (k == 1)
                {
                    Console.WriteLine("d = " + d + "\n" + b);
                    k++;
                    continue;
                }
                k++;
            } while (k < 3);

            foreach (int temp in array)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}