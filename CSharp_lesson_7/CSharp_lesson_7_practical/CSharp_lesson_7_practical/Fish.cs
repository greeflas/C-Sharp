using System;
using System.Linq;

namespace CSharp_lesson_7_practical
{
    class Fish : Animal
    {
        // Public methods
        public Fish(string name) : base(name)
        {

        }

        public override void Breathe()
        {
            base.Breathe();
            Console.WriteLine("gills");
        }
    }
}
