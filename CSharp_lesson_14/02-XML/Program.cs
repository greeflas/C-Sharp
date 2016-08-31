/* XML: classes XmlDocument, XmlNode */

using System;
using System.Xml;

namespace _02_XML
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

            // edit data

            // remove
            XmlNode student = root.ChildNodes[0];
            root.RemoveChild(student);
            students.Save(PATH);

            Console.WriteLine("Deleted!");
        }
    }
}
