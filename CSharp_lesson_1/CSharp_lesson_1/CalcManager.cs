using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_lesson_1
{
    class CalcManager
    {
        double a, b, c;
        double d;
        double x, x1, x2;

        private void inputDouble(ref double n, string text)
        {
            Console.Write(text);
            try
            {
                n = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception err)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("> Error: {0}", err.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public void inputData()
        {
            Console.WriteLine("\nEnter the coefficients of the equation");

            inputDouble(ref a, "a: ");
            inputDouble(ref b, "b: ");
            inputDouble(ref c, "c: ");
        }

        public void CalcResult()
        {
            Console.WriteLine("\nResult");

            if (a != 0)
            {
                d = (b * b) - (4 * a * c);
                if (d > 0)
                {
                    d = Math.Sqrt(d);
                    x1 = (-b - d) / 2 / a;
                    x2 = (-b + d) / 2 / a;

                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
                else if (d == 0)
                {
                    x = -b / 2 / a;
                    Console.WriteLine("x = {0}", x);
                }
                else
                    Console.WriteLine("This equation has no solution!");
            }
            else
            {
                x = -c / b;
                Console.WriteLine("x = {0}", x);
            }
        }
    }
}
