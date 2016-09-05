/* XML: streams */

using System;
using System.Xml;

namespace XmlStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH = "../../data/data.xml";

            // Open stream
            XmlTextReader reader = new XmlTextReader(PATH);
            // Clear from spaces
            reader.WhitespaceHandling = WhitespaceHandling.All;

            // Read data
            while(reader.Read())
            {
                // node type
                XmlNodeType type = reader.NodeType;
                //Console.WriteLine("Node type: {0}", type.ToString());

                // node name
                string name = reader.Name;
                //Console.WriteLine("Node name: {0}", name);

                // node value
                string value = reader.Value;
                //Console.WriteLine("Node value: {0}", value);

                // attributes count
                int attrCount = reader.AttributeCount;
                //Console.WriteLine("Attribute count: {0}", attrCount);
                //Console.WriteLine();

                // read node attributes
                if((reader.NodeType == XmlNodeType.Element) && (reader.AttributeCount > 0))
                {
                    Console.WriteLine("id: {0}", reader.GetAttribute("id"));
                    Console.WriteLine("Title: {0}", reader.GetAttribute("title"));
                    Console.WriteLine("Category: {0}", reader.GetAttribute("category"));
                    Console.WriteLine();
                }
            }

            // close xml stream
            reader.Close();
        }
    }
}
