using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _01_Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH = "../../data/student.dat";

            /* Serialize */

            // Create class object
            Student s = new Student(1, "Vasya", "Pupkin", 10.0);

            // Open file stream
            FileStream fs = new FileStream(PATH, FileMode.Create, FileAccess.Write);

            // Serialize class object and write it to file
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, s);

            fs.Close();

            /* Deserialize */

            // Open file stream
            FileStream fs2 = new FileStream(PATH, FileMode.Open, FileAccess.Read);

            BinaryFormatter bf2 = new BinaryFormatter();
            Student s2 = (Student)bf2.Deserialize(fs2);

            fs2.Close();

            Console.WriteLine(s2.ToString());
        }
    }
}
