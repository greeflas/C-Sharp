using System;
using System.Linq;

namespace CSharp_lesson_8
{
    public interface ICar
    {
        string Mark
        {
            get;
            set;
        }

        float Cylinders
        {
            get;
            set;
        }

        float Power
        {
            get;
            set;
        }
    }
}
