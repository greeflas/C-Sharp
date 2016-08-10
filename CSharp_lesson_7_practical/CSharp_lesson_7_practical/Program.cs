using System;
using System.Linq;

namespace CSharp_lesson_7_practical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<1> - fish");
            Console.WriteLine("<2> - bird");
            Console.WriteLine("<3> - frog");
            Console.Write("> ");
            int ans = Convert.ToInt32(Console.ReadLine());

            Animal Base = null;
            switch(ans)
            {
                case 1:
                    Base = new Fish("ide");
                    break;
                case 2:
                    Base = new Bird("toucan");
                    break;
                case 3:
                    Base = new Frog("princess");
                    break;
            }
            Base.Breathe();
        }
    }
}
