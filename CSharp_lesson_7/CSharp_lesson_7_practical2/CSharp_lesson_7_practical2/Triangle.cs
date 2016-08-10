using System;
using System.Linq;

namespace CSharp_lesson_7_practical2
{
    public class Triangle : Shape
    {
        // Private fields
        double a;
        double b;
        double c;

        // Public methods
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CalcP()
        {
            return a + b + c;
        }

        public override double CalcS()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
