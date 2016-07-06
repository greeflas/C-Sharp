using System;
using System.Linq;

namespace CSharp_lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string
            string s1 = "yo yo yo";

            Console.WriteLine("String: {0}", s1);
            Console.WriteLine("String length: {0}", s1.Length);
            Console.WriteLine("By index: {0}", s1[0]);

            // Compare()
            string a = "hello";
            string b = "we";
            Console.WriteLine(a == b);
            Console.WriteLine(String.Compare(a, b));

            // Substring()
            string info = "blah blah; lya lya lya";
            int index = info.IndexOf(";");
            Console.WriteLine("Index: {0}", index);

            string substr1 = info.Substring(0, index);
            Console.WriteLine("Substr 1: {0}", substr1);

            string substr2 = info.Substring(index + 2);
            Console.WriteLine("Substr 2: {0}", substr2);

            // Split()
            string[] news = info.Split(';');

            Console.WriteLine("\n> Split");
            foreach(string item in news)
                Console.WriteLine(item.Trim());

            // Replace()
            info = info.Replace(";", "#");
            Console.WriteLine("Replace: {0}", info);
        }
    }
}
