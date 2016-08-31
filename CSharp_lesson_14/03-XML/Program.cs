/* XML: classes XmlDocument, XmlNode */

using System;
using System.Xml;

namespace _03_XML
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

            // search student by last name
            Console.Write("Last name: ");
            string studentLname = Console.ReadLine();

            int sID = 0;
            XmlNodeList nodes = students.GetElementsByTagName("student");
            foreach(XmlNode node in nodes)
            {
                if(node.Attributes[2].Value == studentLname)
                    break;
                ++sID;
            }

            Console.Write("New rate: ");
            string rate = Console.ReadLine();
            nodes[sID].Attributes[4].Value = rate;

            students.Save(PATH);
        }
    }
}
