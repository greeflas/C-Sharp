/* Files */

using System;
using System.IO;

namespace CSharp_lesson_13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH_TO_FILE = "D:/tmp/info.txt";

            FileInfo f = new FileInfo(PATH_TO_FILE);

            // File exists
            if(f.Exists)
                Console.WriteLine("Success!");
            else
                Console.WriteLine("Error!");

            // File info
            Console.WriteLine("\n\tFiles information");
            DateTime ct = f.CreationTime;
            Console.WriteLine("Creation time: {0}", ct);

            DateTime lat = f.LastAccessTime;
            Console.WriteLine("Last access time: {0}", lat);

            DateTime lwt = f.LastWriteTime;
            Console.WriteLine("Last write time: {0}", lwt);

            string path = f.FullName;
            Console.WriteLine("Path: {0}", path);

            // Edit file
            StreamWriter sw = f.CreateText();
            sw.Write("Hello, ");
            sw.Close();

            StreamWriter sw2 = f.AppendText();
            sw2.Write("doode.");
            sw2.Close();

            // Read data from file
            StreamReader sr = f.OpenText();
            string data = sr.ReadToEnd();
            Console.WriteLine("\nData: {0}", data);
            sr.Close();

            // Copy files
            FileInfo f2 = f.CopyTo(f.FullName, true);

            f.MoveTo(f.FullName);
        }
    }
}
