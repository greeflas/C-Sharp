using System;
using System.Collections;
using System.Linq;

namespace CSharp_lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList(StartCapacity)
            ArrayList l = new ArrayList(10);
            Console.WriteLine("\tArrayList");
            Console.WriteLine("Capacity: {0}", l.Capacity);
            Console.WriteLine("Count: {0}", l.Count);

            // Add 1 item
            l.Add(0);
            Console.WriteLine("\nCapacity: {0}", l.Capacity);
            Console.WriteLine("Count: {0}", l.Count);

            // Add many item
            l.AddRange(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("\nCapacity: {0}", l.Capacity);
            Console.WriteLine("Count: {0}", l.Count);

            // Capacity x2
            l.AddRange(new int[] { 6, 7, 8, 9, 10 });
            Console.WriteLine("\nCapacity: {0}", l.Capacity);
            Console.WriteLine("Count: {0}", l.Count);

            // Capacity = Count
            l.TrimToSize();
            Console.WriteLine("\nCapacity: {0}", l.Capacity);
            Console.WriteLine("Count: {0}", l.Count);

            l.Add(11);
            Console.WriteLine("\nCapacity: {0}", l.Capacity);
            Console.WriteLine("Count: {0}", l.Count);

            Console.WriteLine();
            foreach (int item in l)
                Console.Write("{0}, ", item);
            Console.WriteLine();
        }
    }
}
