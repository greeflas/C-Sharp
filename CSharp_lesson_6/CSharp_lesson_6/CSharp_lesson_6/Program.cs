using System;
using System.Linq;

namespace CSharp_lesson_6
{
    class ClassProperties
    {
        public int data1;
        public int data2;
        public int data3;

        public int Data1
        {
            get { return data1; }
        }

        public int Data2
        {
            set { data2 = value; }
        }

        public int Data3
        {
            get
            {
                if (data3 == 0)
                    Console.WriteLine("Data3 field is null.");

                return data3;
            }

            set { data3 = value; }
        }

        public int Data4
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassProperties t = new ClassProperties();
            Console.WriteLine(t.Data3);

            t.Data3 = 23;
            Console.WriteLine(t.Data3);

            Console.WriteLine("> {0}", t.Data4);
            t.Data4 = 43;
            Console.WriteLine("> {0}", t.Data4);
        }
    }
}
