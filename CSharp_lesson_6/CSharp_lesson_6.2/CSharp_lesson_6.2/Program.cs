using System;
using System.Linq;

namespace CSharp_lesson_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Student
            Student s = new Student();

            s.Name = "Vasya Pupkin";
            s.Age = 18;
            s.Rate = 11;
            Console.WriteLine(s.ToString());

            // create group
            Group g = new Group();
            Console.WriteLine(g.ToString());

            // add student to group
            g.AddStudent(ref s);
            Console.WriteLine(g.ToString());

            //using indexer
            Console.WriteLine("> Indexer");
            Console.WriteLine(g[0].ToString());
        }
    }
}
