/* XML: classes XmlDocument, XmlNode, XmlNodeList, XmlAttribute */

using System;
using System.Xml;

namespace CSharp_lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH = "../../data/students.xml";

            // create descriptor
            XmlDocument students = new XmlDocument();
            // load xml file to descriptor
            students.Load(PATH);

            // get root tag (<students>)
            XmlNode root = students.DocumentElement;

            // read data
            XmlNodeList nodes = students.GetElementsByTagName("student");
            foreach (XmlNode node in nodes)
            {
                foreach (XmlAttribute attr in node.Attributes)
                {
                    Console.Write("{0}: ", attr.Name);
                    Console.WriteLine(attr.Value);
                }
                Console.WriteLine();
            }
        }
    }
}
