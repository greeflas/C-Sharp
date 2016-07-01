using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DialogManager dm = new DialogManager();

            dm.Start();
            do
            {
                dm.DisplayMenu();
                switch(dm.Choise)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            } while(dm.AllowContinue());
            dm.Finish();
        }
    }
}
