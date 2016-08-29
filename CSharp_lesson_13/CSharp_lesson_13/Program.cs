/* Directories */

using System;
using System.IO;

namespace CSharp_lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH = "D:/tmp";

            // Create dir
            DirectoryInfo d = new DirectoryInfo(PATH);
            if(d.Exists)
            {
                DirectoryInfo subDir1 = d.CreateSubdirectory("sub-dir");
                DirectoryInfo subDir2 = d.CreateSubdirectory("sub-dir-2");
                DirectoryInfo subDir3 = d.CreateSubdirectory("sub-dir-3");

                if(subDir2.Exists)
                {
                    d.CreateSubdirectory("sub-dir-2/sub-sub-dir");
                }

                if(subDir3.Exists)
                {
                    DirectoryInfo subSubDir = subDir3.CreateSubdirectory("sub-sub-dir");
                }

                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Error!");
            }

            // Delete dir
            try
            {
                DirectoryInfo subD = new DirectoryInfo(PATH + "/sub-dir");
                subD.Delete();

                DirectoryInfo subD2 = new DirectoryInfo(PATH + "/sub-dir-2");
                // true - recursively removing
                subD2.Delete(true);
            }
            catch(Exception error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Error]: {0}", error.Message);
                Console.ResetColor();
            }

            // Directory info
            Console.WriteLine("\n\tDirectory information");
            DateTime ct = d.CreationTime;
            Console.WriteLine("Creation time: {0}", ct);

            DateTime lat = d.LastAccessTime;
            Console.WriteLine("Last access time: {0}", lat);

            DateTime lwt = d.LastWriteTime;
            Console.WriteLine("Last write time: {0}", lwt);

            string path = d.FullName;
            Console.WriteLine("Path: {0}", path);

            string rootPath = d.Root.ToString();
            Console.WriteLine("Root path: {0}", rootPath);

            // Files and dirs in the directory
            Console.WriteLine("\n\tDirs");

            DirectoryInfo[] dirictories = d.GetDirectories();
            foreach(DirectoryInfo dir in dirictories)
            {
                Console.WriteLine(dir.Name);
            }

            Console.WriteLine("\n\tfiles");
            // GetFiles("*.txt")
            FileInfo[] files = ( new DirectoryInfo(PATH + "/sub-dir-3") ).GetFiles();
            foreach(FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}
