using System;
using System.Linq;

namespace CSharp_lesson_7_practical2
{
    public class Circle : Shape
    {
        // Private fields
        private double r;

        // Public methods
        public Circle(double r)
        {
            this.r = r;
        }

        public override double CalcP()
        {
            throw new System.NotImplementedException();
        }

        public override double CalcS()
        {
            throw new System.NotImplementedException();
        }
    }
}
