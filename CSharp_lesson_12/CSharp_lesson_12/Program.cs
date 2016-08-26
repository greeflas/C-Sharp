/* Generic collections */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            ListPerson lp = new ListPerson();

            lp.addPerson();
            lp.addPerson();

            lp.displayByLastName();

            lp.removePerson();
            lp.displayPersons();
        }
    }
}
