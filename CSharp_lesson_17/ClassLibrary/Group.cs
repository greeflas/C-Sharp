using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Group
    {
        protected string name;
        protected List<Student> students;

        protected bool isGroupEmpty()
        {
            return (students.Count == 0) ? true : false;
        }

        public Group(string name)
        {
            this.name = name;
            students = new List<Student>();
        }

        public void DisplayGroup()
        {
            if(!isGroupEmpty())
            {
                Console.WriteLine("\tGroup name: {0}", name);
                foreach(Student s in students)
                {
                    Console.WriteLine(s.ToString());
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Group is not contains students!");
            }
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }
    }
}
