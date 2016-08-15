using System;
using System.Linq;

namespace CSharp_lesson_8
{
    public class Lorry : ICar
    {
        // Private fields
        string mark;
        float cylinders;
        float power;
        float capacity;

        // Properties
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public float Cylinders
        {
            get { return cylinders; }
            set { cylinders = value; }
        }

        public float Power
        {
            get { return power; }
            set { power = value; }
        }

        public float Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        // Public methods
        public Lorry(string mark, float cylinders, float power, float capacity)
        {
            this.mark = mark;
            this.cylinders = cylinders;
            this.power = power;
            this.capacity = capacity;
        }

        public override string ToString()
        {
            return String.Format("Mark: {0} \nCylinders: {1} \nPower: {2} \nCapacity: {3}\n", 
                mark, cylinders, power, capacity);
        }
    }
}
