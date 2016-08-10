using System;
using System.Linq;

namespace CSharp_lesson_7
{
    public class Human
    {
        // Protected fields
        protected string name;
        protected uint age;

        // Public methods
        public Human(string name, uint age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} \nAge: {1}\n", name, age);
        }
    }
}
