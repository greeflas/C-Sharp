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
                    case 0:
                        goto finish;
                        break;
                    case 1:
                        CalcManager cl = new CalcManager();
                        cl.inputData();
                        cl.CalcResult();
                        break;
                }
            } while(dm.AllowContinue());

            finish:
            dm.Finish();
        }
    }
}
