using System;
using System.Linq;

namespace CSharp_lesson_7_practical
{
    class Bird : Animal
    {
        // Public methods
        public Bird(string name) : base(name)
        {

        }

        public override void Breathe()
        {
            base.Breathe();
            Console.WriteLine("lungs");
        }
    }
}
