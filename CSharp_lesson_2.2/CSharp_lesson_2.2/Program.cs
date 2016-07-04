using System;

namespace CSharp_lesson_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = r.Next(0, 10);
                if(num % 2 == 0 && num != 0)
                {
                    Console.Write("> ");
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine("\tPythagoras table of multiply\n");
            for (int i = 1; i < 10; i++ )
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i * j != 1)
                        Console.Write("{0, 4}", i * j);
                    else
                        Console.Write("{0, 4}", " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }
    }
}
