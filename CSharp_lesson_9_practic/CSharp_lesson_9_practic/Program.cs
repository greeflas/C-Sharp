using System;
using System.Linq;

namespace CSharp_lesson_9_practic
{
    class Program
    {
        static void Main(string[] args)
        {
            Article a = new Article(1, "Photocamera", 20000.99, ArticleType.Photocameras);
            Console.WriteLine(a.ToString());
        }
    }
}
