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
            return 2 * Math.PI * r;
        }

        public override double CalcS()
        {
            double d = 2 * r;
            double s = (Math.PI / 4) * (d * d);

            return s;
        }
    }
}
