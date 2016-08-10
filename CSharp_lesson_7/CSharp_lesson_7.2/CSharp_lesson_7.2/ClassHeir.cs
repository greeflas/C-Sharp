using System;
using System.Linq;

namespace CSharp_lesson_7._2
{
    class ClassHeir : BaseClass
    {
        // Private fields
        double number2;

        // Public methods
        public ClassHeir(int number, double number2) : base(number)
        {
            this.number = number;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Number2: {0}", number2);
        }

        public double SquareSum()
        {
            return (number * 2) + (number2 * 2);
        }

        // Redefinition BaseClass method
        public override int Calc()
        {
            return -(number * 3);
        }
    }
}
