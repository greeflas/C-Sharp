﻿using System;

namespace CSharp_lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 0, b = 0, c = 0;

            // Input a
            Console.WriteLine("Input a");
            Console.Write("> ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception err)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(err.Message);
                Console.ResetColor();
            }
            Console.WriteLine();

            // Input b
            Console.WriteLine("Input b");
            Console.Write("> ");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception err)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(err.Message);
                Console.ResetColor();
            }
            Console.WriteLine();

            // Input b
            Console.WriteLine("Input c");
            Console.Write("> ");
            try
            {
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception err)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(err.Message);
                Console.ResetColor();
            }
            Console.WriteLine();

            // Check data
            bool f1 = false;
            bool f2 = false;
            bool f3 = false;

            int sum = a + b;
            if(c < sum)
                f1 = true;

            sum = c + b;
            if (a < sum)
                f2 = true;

            sum = a + c;
            if (b < sum)
                f3 = true;

            // Result to string
            Console.Write("Result : ");
            if (f1 && f2 && f3)
                Console.WriteLine("True!");
            else
                Console.WriteLine("False!");*/

            int month = 0;

            Console.WriteLine("Inpuit the month (1-12)");
            Console.Write("> ");
            try
            {
                month = Convert.ToInt16(Console.ReadLine());
            }
            catch(Exception err)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(err.Message);
                Console.ResetColor();
            }

            Console.Write("> ");
            switch (month)
            {
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Authumn");
                    break;
                case 12:
                    Console.WriteLine("Winter");
                    break;
            }
        }
    }
}
