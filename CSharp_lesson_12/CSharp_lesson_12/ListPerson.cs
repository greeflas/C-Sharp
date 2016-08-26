using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_lesson_12
{
    class ListPerson
    {
        // Private fields
        List<Person> persons;
        List<Zodiac> zodiacs;

        // Private methods
        string getData(string label)
        {
            Console.Write(label + ": ");

            string val = "";
            try
            {
                val = Console.ReadLine();
            }
            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Error]: {0}", error.Message);
                Console.ResetColor();
            }

            return val;
        }

        private Person getPersonByLastName(string lname)
        {
            if (personsIsEmpty())
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                foreach (Person p in persons)
                    if (p.LastName == lname)
                        return p;
            }

            return null;
        }

        private bool personsIsEmpty()
        {
            return (persons.Count == 0) ? true : false;
        }

        // Public methods
        public ListPerson()
        {
            persons = new List<Person>();
            zodiacs = new List<Zodiac>();

            zodiacs.Add(new Zodiac("Овен", "0001.03.21", "0001.04.19"));
            zodiacs.Add(new Zodiac("Телец", "0001.04.20", "0001.05.20"));
            zodiacs.Add(new Zodiac("Близнецы", "0001.05.21", "0001.06.20"));
            zodiacs.Add(new Zodiac("Рак", "0001.06.21", "0001.07.22"));
            zodiacs.Add(new Zodiac("Лев", "0001.07.23", "0001.08.22"));
            zodiacs.Add(new Zodiac("Дева", "0001.08.23", "0001.09.22"));
            zodiacs.Add(new Zodiac("Весы", "0001.09.23", "0001.10.22"));
            zodiacs.Add(new Zodiac("Скорпион", "0001.10.23", "0001.11.21"));
            zodiacs.Add(new Zodiac("Стрелец", "0001.11.22", "0001.31.21"));
            zodiacs.Add(new Zodiac("Козерог", "0001.31.22", "0001.01.19"));
            zodiacs.Add(new Zodiac("Водолей", "0001.01.20", "0001.02.18"));
            zodiacs.Add(new Zodiac("Рыбы", "0001.02.19", "0001.03.20"));
        }

        public void displayPersons()
        {
            if(personsIsEmpty())
            {
                Console.WriteLine("List is empty!");
                return;
            }

            int id = 0;
            foreach(Person p in persons)
            {
                Console.WriteLine("\t#{0}", ++id);
                Console.WriteLine(p.ToString());
                Console.WriteLine();
            }
        }

        public void addPerson()
        {
            string fname = getData("First name");
            string lname = getData("Last name");
            string birthDate = getData("Birth date");

            DateTime birth = new DateTime();
            try
            {
                birth = Convert.ToDateTime(birthDate);
            }
            catch(Exception error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Error]: {0}", error.Message);
                Console.ResetColor();
            }

            persons.Add(new Person(fname, lname, birth));
        }

        public void removePerson()
        {
            if (personsIsEmpty())
            {
                Console.WriteLine("List is empty!");
                return;
            }

            displayPersons();
            Console.Write("Index > ");
            int index = Convert.ToInt32(Console.ReadLine());

            persons.RemoveAt(index - 1);
        }

        public void displayByLastName()
        {
            string lname = getData("Last name");
            Person p = getPersonByLastName(lname);

            if (p != null)
                Console.WriteLine(p.ToString());
            else
                Console.WriteLine("Person not found!");
        }
    }
}
