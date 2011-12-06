using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{
    class Program6
    {
        internal static void structOne()
        {
            Console.Clear();

            Point p;
            Dimension d;

            Console.WriteLine("Initializing the Point struct...");
            p = new Point(1, 1);

            Console.WriteLine("Initializing the Dimension object...");
            d = new Dimension(1, 1);

            Console.WriteLine("Point vector: {0}", p.vector);
            Console.WriteLine("Dimension diagonal: {0}", d.Diagonal());

            Console.ReadLine();
            return;
        }
    }

    struct Point
    {
        private int A;
        private int B;

        public Point(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public double vector
        {
            get
            {
                return Math.Sqrt(A * A + B * B);
            }
        }
    }

    class Dimension
    {
        private int X;
        private int Y;

        public Dimension(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Diagonal()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
}
