using System;

namespace CSharp_lesson_7_practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = null;
            int ans = 0;

            Console.WriteLine("<1> - Rectangle");
            Console.WriteLine("<2> - Triangle");
            Console.WriteLine("<3> - Circle");
            Console.Write("> ");
            try
            {
                ans = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error: {0}", error.Message);
                Console.ResetColor();
            }

            switch(ans)
            {
                case 1:
                    s = new Rectangle(2, 4);
                    break;
                case 2:
                    s = new Triangle(4, 8, 5);
                    break;
                case 3:
                    s = new Circle(56);
                    break;
            }

            if(s != null)
            {
                Console.WriteLine();
                Console.WriteLine("P: {0:0.00}", s.CalcP());
                Console.WriteLine("S: {0:0.00}", s.CalcS());
            }
        }
    }
}
