using System;
using ClassLibrary;

namespace DynamicLinkLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Group Group9pv5 = new Group("9pv5");

            Group9pv5.AddStudent(new Student("Vasya", "Pupkin", 16));

            Group9pv5.DisplayGroup();
        }
    }
}
