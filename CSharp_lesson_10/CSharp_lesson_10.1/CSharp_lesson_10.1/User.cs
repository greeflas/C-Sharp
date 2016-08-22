using System;
using System.Linq;

namespace CSharp_lesson_10._1
{
    class User
    {
        // Private fields
        string username;
        string first_name;
        string last_name;
        string email;

        // Properties
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string FirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Public methods
        public User(string username, string first_name,
            string last_name, string email)
        {
            this.username = username;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
        }

        public override string ToString()
        {
            return String.Format("Username: {0} \nFirst name: {1} \nLast name: {2} \nE-mail: {3}",
                username, first_name, last_name, email);
        }

        public void Handler()
        {
            Console.WriteLine(ToString());
        }
    }
}
