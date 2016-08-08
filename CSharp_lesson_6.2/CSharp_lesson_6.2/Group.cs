using System;
using System.Linq;

namespace CSharp_lesson_6._2
{
    class Group
    {
        // private fields
        Student[] students;

        // private methods
        bool isEmpty()
        {
            return (students == null);
        }

        // public methods
        public Group()
        {
            students = null;
        }

        public void AddStudent(ref Student s)
        {
            if(isEmpty())
            {
                students = new Student[1];
                students[0] = s;
            }
            else
            {
                int size = students.Length + 1;
                Array.Resize(ref students, size);
                students[size] = s;
            }
        }

        public override string ToString()
        {
            if(isEmpty())
                return "Group is empty!";

            string studentsInfo = "";
            foreach(Student item in students)
            {
                studentsInfo += item.ToString();
                studentsInfo += "\n";
            }

            return studentsInfo;
        }

        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Group is empty!");
                return;
            }

            foreach(Student item in students)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }

        // Indexer
        public Student this[int index]
        {
            get { return students[index]; }
            set { students[index] = value; }
        }
    }
}
