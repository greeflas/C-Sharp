using System;
using System.Xml;

namespace GoodsCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            DialogManager dm = new DialogManager();
            while (dm.GeneralMenu());
        }
    }
}
