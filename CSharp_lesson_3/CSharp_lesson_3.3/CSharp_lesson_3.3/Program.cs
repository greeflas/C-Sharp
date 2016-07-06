using System;
using System.Linq;
using System.IO;

namespace CSharp_lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // path to data file
            const string PATH_TO_INPUT_FILE = @"..\..\Data\input.txt";

            // open file
            FileStream rf =
                new FileStream(PATH_TO_INPUT_FILE, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(rf);

            // read data from file
            string content = sr.ReadToEnd();
            Console.WriteLine(content);
            Console.WriteLine();

            // close file
            sr.Close();
            rf.Close();

            // add corrections
            content = content.Replace("bullshit", "b*llsh*t");
            content = content.Replace("fuck", "f*ck");
            content = content.Replace("damn", "d*mn");

            // path to data file
            const string PATH_TO_OUTPUT_FILE = @"..\..\Data\output.txt";

            // open file
            FileStream wf =
               new FileStream(PATH_TO_OUTPUT_FILE, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(wf);

            // write to file
            sw.Write(content);

            // close file
            sw.Close();
            wf.Close();
        }
    }
}
