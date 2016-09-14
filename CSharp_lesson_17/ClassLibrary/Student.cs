using System;

namespace ClassLibrary
{
    public class Student
    {
        protected string first_name;
        protected string last_name;
        protected uint age;
        protected double rate;

        public double Rate
        {
            get { return rate; }
            set {  rate = value; }
        }

        public Student(string first_name, string last_name, uint age)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
        }

        public override string ToString()
        {
            return String.Format(
                    "Name: {0} {1}\n"+
                    "Age: {2}\n"+
                    "Rate: {3}\n",
                    first_name,
                    last_name,
                    age,
                    rate
                );
        }
    }
}
