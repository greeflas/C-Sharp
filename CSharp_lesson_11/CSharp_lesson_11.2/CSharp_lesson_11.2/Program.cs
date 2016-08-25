using System;
using System.Collections;

namespace CSharp_lesson_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack
            Console.WriteLine("\tStack");
            Stack s = new Stack(5);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);

            foreach (int item in s)
                Console.WriteLine(item);

            Console.WriteLine("Count: {0}", s.Count);

            Console.WriteLine("Pop: {0}", s.Pop());
            Console.WriteLine("Count: {0}", s.Count);

            // Queue
            Console.WriteLine("\n\tQueue");
            Queue q = new Queue(3);

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            foreach (int item in q)
                Console.WriteLine(item);

            Console.WriteLine("Count: {0}", q.Count);

            Console.WriteLine("Dequeue: {0}", q.Dequeue());
            Console.WriteLine("Count: {0}", q.Count);

            // Sorted list
            Console.WriteLine("\n\tSorted List");
            SortedList l = new SortedList(2);

            l.Add(5, "blah-blah-blah");
            l.Add(2, "lya-lya-lya");

            Console.WriteLine("Keys");
            foreach (int item in l.GetKeyList())
                Console.WriteLine(item);

            Console.WriteLine("\nValues");
            foreach (string item in l.GetValueList())
                Console.WriteLine(item);

            Console.WriteLine("\nList");
            for (int i = 0; i < l.Count; i++)
                Console.WriteLine("[{0}] => \"{1}\"", l.GetKey(i), l.GetByIndex(i));
        }
    }
}
