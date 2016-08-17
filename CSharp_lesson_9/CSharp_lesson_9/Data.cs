using System;
using System.Linq;

namespace CSharp_lesson_9
{
    struct Data
    {
        public int a;
        public long b;
        public double c;
        public bool d;
        public string e;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public Data(int a, long b, double c, bool d, string e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        public override string ToString()
        {
            return String.Format("A: {0} \nB: {1} \nC: {2} \nD: {3} \nE: {4}\n",
                a, b, c, d, e);
        }
    }
}
