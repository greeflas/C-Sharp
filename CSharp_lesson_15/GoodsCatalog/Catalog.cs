using System;
using System.Xml;
using System.Collections.Generic;
using System.Text;

namespace GoodsCatalog
{
    class Catalog
    {
        // private fields
        string catalogPath;
        string fileName;
        List<Goods> catalog;

        // public methods
        public Catalog()
        {
            catalog = new List<Goods>();
        }

        public Catalog(string catalogPath, string fileName)
        {
            catalog = new List<Goods>();
            this.catalogPath = catalogPath;
            this.fileName = fileName;
        }

        public void init()
        {
            XmlTextReader reader = new XmlTextReader(catalogPath + fileName);
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

        public void Update(string fileName)
        {
            XmlTextWriter writer = new XmlTextWriter(catalogPath + fileName, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("goods");

            writer.WriteStartElement("product");
            writer.WriteAttributeString("id", "3");
            writer.WriteAttributeString("title", "iPad mini");
            writer.WriteAttributeString("category", "Tablets");
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Close();
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
