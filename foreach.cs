using System;
using System.Collections;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, -1, 2, -3, 4, -5, 6, -7, 8, -9 };

            Console.WriteLine("foreach");
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\nIEnumerator");
            IEnumerable enbl = arr;
            IEnumerator entr = enbl.GetEnumerator();

            entr.Reset();
            while(entr.MoveNext())
            {
                Console.Write(entr.Current + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
