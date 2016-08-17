/* Enums */

using System;
using System.Linq;

namespace CSharp_lesson_9._1
{
    enum Days : uint
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            try
            {
                Console.WriteLine("Enter number of the current day");
                Console.Write("> ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(error.Message);
                Console.ResetColor();
            }

            string[] Names = Enum.GetNames(typeof(Days));
//            foreach(string name in Names)
//                Console.WriteLine(name);

            Days day = (Days)input;
            string day_name = "";

            switch(day)
            {
                case Days.Monday:
                    day_name = Enum.GetName(typeof(Days), Days.Monday);
                    break;
                case Days.Tuesday:
                    day_name = Enum.GetName(typeof(Days), Days.Tuesday);
                    break;
                case Days.Wednesday:
                    day_name = Enum.GetName(typeof(Days), Days.Wednesday);
                    break;
                case Days.Thursday:
                    day_name = Enum.GetName(typeof(Days), Days.Thursday);
                    break;
                case Days.Friday:
                    day_name = Enum.GetName(typeof(Days), Days.Friday);
                    break;
                case Days.Saturday:
                    day_name = Enum.GetName(typeof(Days), Days.Saturday);
                    break;
                case Days.Sunday:
                    day_name = Enum.GetName(typeof(Days), Days.Sunday);
                    break;
                default:
                    day_name = "Bad number!";
                    break;
            }

            Console.WriteLine(day_name);
            Console.WriteLine();
        }
    }
}
