using System;
using System.Linq;

namespace CSharp_lesson_7_practical
{
    class Frog : Animal
    {
        // Public methods
        public Frog(string name) : base(name)
        {

        }

        public override void Breathe()
        {
            base.Breathe();
            Console.WriteLine("skin");
        }
    }
}
