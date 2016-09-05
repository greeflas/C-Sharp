using System;
using System.Xml;
using System.Collections.Generic;

namespace GoodsCatalog
{
    class Catalog
    {
        // private fields
        string path;
        List<Goods> catalog;

        // public methods
        public Catalog()
        {
            catalog = new List<Goods>();
        }

        public Catalog(string path)
        {
            catalog = new List<Goods>();
            this.path = path;
        }

        public void init()
        {
            XmlTextReader reader = new XmlTextReader(path);
            reader.WhitespaceHandling = WhitespaceHandling.All;

            while(reader.Read())
            {
                if((reader.NodeType == XmlNodeType.Element) && (reader.AttributeCount > 0))
                {
                    int id = Convert.ToInt32(reader.GetAttribute("id"));
                    string title = reader.GetAttribute("title");
                    string category = reader.GetAttribute("category");

                    Goods g = new Goods(id, title, category);
                    catalog.Add(g);
                }
            }

            reader.Close();
        }

        public void DisplayCatalog()
        {
            foreach(Goods g in catalog)
            {
                Console.WriteLine(g.ToString());
                Console.WriteLine();
            }
        }
    }
}
