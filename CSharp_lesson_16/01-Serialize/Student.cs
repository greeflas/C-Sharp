using System;

namespace _01_Serialize
{
    [Serializable]
    class Student
    {
        // Private fields
        uint id;
        string first_name;
        string last_name;
        double rate;

        // Properties
        public uint Id
        {
            get { return id; }
            set { id = value; }
        }

        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        // Public methods
        public Student(uint id, string first_name, string last_name, double rate)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.rate = rate;
        }

        public override string ToString()
        {
            return String.Format(
                "id: {0}"+
                "\nFirst name: {1}"+
                "\nLast name: {2}"+
                "\nRate: {3}",

                id,
                first_name,
                last_name,
                rate
            );
        }
    }
}
