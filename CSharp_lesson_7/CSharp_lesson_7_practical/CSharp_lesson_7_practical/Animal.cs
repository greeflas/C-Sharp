using System;
using System.Linq;

namespace CSharp_lesson_7_practical
{
    class Animal
    {
        // Protected field
        protected string name;

        // Public methods
        public Animal(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\n", name);
        }

        public virtual void Breathe()
        {
            Console.Write("Breathe ");
        }
    }
}
