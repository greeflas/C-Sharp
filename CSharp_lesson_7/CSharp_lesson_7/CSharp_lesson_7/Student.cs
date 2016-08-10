using System;
using System.Linq;

namespace CSharp_lesson_7
{
    public class Student : Human
    {
        // Private fields
        float rate;

        // Properties
        public float Rate
        {
            set { rate = value; }
        }

        // Public methods
        public Student(string name, uint age, float rate) : 
            base(name, age)
        {
            this.rate = rate;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Rate: {0}", rate);
        }
    }
}
