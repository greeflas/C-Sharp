using System;
using System.Linq;

namespace CSharp_lesson_7._2
{
    class BaseClass
    {
        // Protected fields
        protected int number;

        // Public methods
        public BaseClass(int number)
        {
            this.number = number;
        }

        public override string ToString()
        {
            return String.Format("Number: {0}\n", number);
        }

        public virtual int Calc()
        {
            return number * 2;
        }
    }
}
