using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1
{
    /// <summary>
    /// A struct for a point in space
    /// </summary>
    struct Point
    {
        private double xval, yval;
        public double x
        {
            get
            {
                return xval;
            }
            set
            {
                xval = value;
            }
        }
        public double y
        {
            get
            {
                return yval;
            }
            set
            {
                yval = value;
            }
        }
        public void DisplayX()
        {
            Console.WriteLine("X = {0}", xval);
        }
        public void DisplayY()
        {
            Console.WriteLine("Y = {0}", yval);
        }
        public void DisplayPoint()
        {
            Console.WriteLine("X = {0, 3}, Y = {1, 3}, Name: {2}", xval, yval, this.GetType().MemberType);
        }
    }

    class Program5
    {
        /// <summary>
        /// A method for testing structs and hos to work with them.
        /// </summary>
        internal static void structs()
        {
            Point point = new Point();

            point.x = getNumber("x");
            point.y = getNumber("y");

            point.DisplayX();
            point.DisplayY();
            point.DisplayPoint();

            Console.ReadLine();
        }

        /// <summary>
        /// A method for parsing the text the user wrote in the terminal
        /// </summary>
        /// <param name="accis">Taking in a string containing the letter of the accis that is getting a point</param>
        /// <returns>A double containing the number to be set in the point.</returns>
        private static double getNumber(string accis)
        {
            double q=0;
            bool error = true;
            string answer;

            do
            {
                try
                {
                    Console.Write("Set {0}: ", accis);
                    answer = Console.ReadLine();
                    answer = answer.Replace('.', ',');
                    q = double.Parse(answer);
                    error = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Not something I can parse to a number.\nTry again.");
                }
            } while (error);

            return q;
        }
    }
}
