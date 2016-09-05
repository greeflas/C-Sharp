using System;

namespace GoodsCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH = "../../data/goods.xml";

            Catalog c = new Catalog(PATH);
            c.init();
            c.DisplayCatalog();
        }
    }
}
