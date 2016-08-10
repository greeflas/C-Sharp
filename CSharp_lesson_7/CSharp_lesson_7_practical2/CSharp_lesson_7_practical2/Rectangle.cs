using System;
using System.Linq;

namespace CSharp_lesson_7_practical2
{
    public class Rectangle : Shape
    {
        // Private fields
        double a;
        double b;

        // Public methods
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double CalcP()
        {
            return (a + b) * 2;
        }

        public override double CalcS()
        {
            return a * b;
        }
    }
}
