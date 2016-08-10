/* Inheritance */

using System;
using System.Linq;

namespace CSharp_lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Base class
            Human h = new Human("Vasya Pupkin", 18);
            Console.WriteLine(h.ToString());

            // Class heir
            Student s = new Student("Sveta Pupkina", 19, 11);
            Console.WriteLine(s.ToString());
        }
    }
}
