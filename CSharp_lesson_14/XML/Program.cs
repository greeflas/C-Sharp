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

            // create node
            XmlElement newNode = students.CreateElement("student");

            XmlAttribute id = students.CreateAttribute("id");
            XmlAttribute fname = students.CreateAttribute("fname");
            XmlAttribute lname = students.CreateAttribute("lname");
            XmlAttribute age = students.CreateAttribute("age");
            XmlAttribute rate = students.CreateAttribute("rate");

            Console.Write("id > ");
            id.Value = Console.ReadLine();
            Console.Write("First name > ");
            fname.Value = Console.ReadLine();
            Console.Write("Last name > ");
            lname.Value = Console.ReadLine();
            Console.Write("Age > ");
            age.Value = Console.ReadLine();
            Console.Write("Rate > ");
            rate.Value = Console.ReadLine();

            newNode.Attributes.Append(id);
            newNode.Attributes.Append(fname);
            newNode.Attributes.Append(lname);
            newNode.Attributes.Append(age);
            newNode.Attributes.Append(rate);

            root.AppendChild(newNode);
            students.Save(PATH);
        }
    }
}
