/* Interface */

using System;
using System.Linq;

namespace CSharp_lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Lorry l = new Lorry("Kamaz", 8, 2000, 100);
            Console.WriteLine(l.ToString());

            l.Power = 2500;
            l.Capacity = 200;
            Console.WriteLine(l.ToString());

            ICar c = new Lorry("Kamaz", 4, 1000, 300);
            Console.WriteLine(c.ToString());

            c.Mark = "Mercedez";
            Console.WriteLine(c.ToString());
        }
    }
}
