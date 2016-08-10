/* Polymorphism */

using System;
using System.Linq;

namespace CSharp_lesson_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Base class
            BaseClass b = new BaseClass(2);
            Console.WriteLine("Square: {0}", b.Calc());

            // Class heir
            ClassHeir h = new ClassHeir(2, 5);
            Console.WriteLine("Cub: {0}\n", h.Calc());

            /* Dynamic polymorphism */

            // 1. In the base class need add keyword "virtual" to the method
            // 2. In the heir class need add keyword "override" to the method
            BaseClass bs;

            bs = new BaseClass(2);
            Console.WriteLine("Calc method: {0}", bs.Calc());
            Console.WriteLine(bs.ToString());

            bs = new ClassHeir(2, 4);
            Console.WriteLine("Calc method: {0}", bs.Calc());
            Console.WriteLine(bs.ToString());
        }
    }
}
