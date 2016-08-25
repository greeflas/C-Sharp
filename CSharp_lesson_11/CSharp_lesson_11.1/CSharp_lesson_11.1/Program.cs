using System;
using System.Collections;

namespace CSharp_lesson_11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // List 1
            ArrayList l1 = new ArrayList(5);

            Student s1 = new Student("Vasya Pupkin", 18);
            l1.Add(s1);

            l1.Add(new Student("Sveta Pupkina", 19));
            l1.Add(new Student("Petro", 23));
            l1.Add(new Student("Anastasia Franko", 20));
            l1.Add(new Student("Irina Petrova", 17));

            foreach (Student s in l1)
            {
                Console.WriteLine(s.ToString());
                Console.WriteLine();
            }

            // Remove(item)
            l1.Remove(s1);
            Console.WriteLine();
            foreach (Student s in l1)
            {
                Console.WriteLine(s.ToString());
                Console.WriteLine();
            }

            // List 2
            ArrayList l2 = new ArrayList(5);
            l2.AddRange(new int[] { 24, 76, 89, 69, 12 });

            Console.WriteLine();
            foreach (int item in l2)
                Console.WriteLine(item);

            // Insert(position, item)
            try
            {
                l2.Insert(12, 777);
            }
            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[error]: {0}", error.Message);
                Console.ResetColor();
            }

            l2.Insert(1, 888);
            Console.WriteLine();
            foreach (int item in l2)
                Console.WriteLine(item);

            // RemoveAt(index)
            try
            {
                l2.RemoveAt(12);
            }
            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[error]: {0}", error.Message);
                Console.ResetColor();
            }

            l2.RemoveAt(0);
            Console.WriteLine();
            foreach (int item in l2)
                Console.WriteLine(item);

            // Remove(item)
            l2.Remove(-1);
            Console.WriteLine();
            foreach (int item in l2)
                Console.WriteLine(item);

            l2.Add(888);
            Console.WriteLine();
            foreach (int item in l2)
                Console.WriteLine(item);

            l2.Remove(888);
            Console.WriteLine();
            foreach (int item in l2)
                Console.WriteLine(item);

            l2.Remove(888);
            Console.WriteLine();
            foreach (int item in l2)
                Console.WriteLine(item);

            // GetRange(startPos, itemsCount)
            ArrayList l3 = l2.GetRange(0, 2);

            Console.WriteLine();
            foreach (int item in l3)
                Console.WriteLine(item);
        }
    }
}
