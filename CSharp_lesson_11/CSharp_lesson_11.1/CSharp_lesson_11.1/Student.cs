using System;

namespace CSharp_lesson_11._1
{
    class Student
    {
        // Private fields
        string name;
        uint age;

        // Public methods
        public Student(string name, uint age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} \nAge: {1}", name, age);
        }

        // Override operators
//        public static bool operator!=(Student a, Student b)
//        {
//            if (a.name != b.name && a.age != b.age)
//                return true;
//
//            return false;
//        }

//        public static bool operator==(Student a, Student b)
//        {
//            if(a.name == b.name && a.age == b.age)
//                return true;
//
//            return false;
//        }
    }
}
