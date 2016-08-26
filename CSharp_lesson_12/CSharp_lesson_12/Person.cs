using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_lesson_12
{
    class Person
    {
        // Private fields
        string fname;
        string lname;
        DateTime birthDate;

        // Properties
        public string LastName
        {
            get { return lname; }
        }

        // Public methods
        public Person(string fname, string lname, DateTime birthDate)
        {
            this.fname = fname;
            this.lname = lname;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return String.Format("First Name: {0} \nLast Name: {1} \nBirth Date: {2}\n",
                fname, lname, birthDate.ToLongDateString());
        }
    }
}
