using System;
using System.Linq;

namespace CSharp_lesson_7_practical2
{
    public abstract class Shape
    {
        // Public methods
        public virtual double CalcP()
        {
            throw new System.NotImplementedException();
        }

        public virtual double CalcS()
        {
            throw new System.NotImplementedException();
        }
    }
}
