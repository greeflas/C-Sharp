using System;
using System.Linq;

namespace CSharp_lesson_6._2
{
    class Student
    {
        // private fields
        string name;
        uint age;
        float rate;

        // properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public uint Age
        {
            get { return age; }
            set { age = value; }
        }

        public float Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        // public methods
        public Student()
        {
            name = "-";
            age = 0;
            rate = 0;
        }

        public override string ToString()
        {
            return String.Format("Student \nName: {0}\nAge: {1} \nRate: {2}\n", name, age, rate);
        }
    }
}
