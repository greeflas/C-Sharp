using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_lesson_1
{
    class DialogManager
    {
        // Private fields
        int choise;
        string ans;

        // Public properties
        // getter for private 'choise' field
        public int Choise
        {
            get { return choise; }
        }

        // Public methods
        public void Start()
        {
            Console.WriteLine("\t=======================");
            Console.WriteLine("\tMy first program on C#");
            Console.WriteLine("\t=======================");
        }

        public void Finish()
        {
            Console.WriteLine("Bye :)");
        }

        public bool AllowContinue()
        {
            Console.WriteLine("> Continie? (y/n) - ");
            ans = Console.ReadLine();

            return (ans == "y");
        }

        public void DisplayMenu()
        {
            Console.WriteLine("<1> - solve the equation");
            Console.WriteLine("<2> - solve the new equation");
            Console.WriteLine("<3> - exit");
            Console.WriteLine("> Your choise? - ");
            try
            {
                choise = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception err)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("> Mudak youpt! : {0}", err.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
