using System;

namespace GoodsCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CATALOG_PATH = "../../data/";
            const string FILE_NAME = "goods.xml";

            Catalog c = new Catalog(CATALOG_PATH, FILE_NAME);
            c.init();
            c.DisplayCatalog();

            c.Update("update.xml");
        }
    }
}
