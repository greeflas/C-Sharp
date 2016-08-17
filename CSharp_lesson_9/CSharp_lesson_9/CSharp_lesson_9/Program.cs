/* Stuctures */

/*
Difference
    Class - reference type, heap
    Struct - value type, stack
 */

using System;
using System.Linq;

namespace CSharp_lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data(4, 999999999999999999, 123.9000, true, "hello");
            Console.WriteLine(d.ToString());

            Data test = d;
            test.A = 6;

            Console.WriteLine(d.ToString());
            Console.WriteLine(test.ToString());
        }
    }
}
