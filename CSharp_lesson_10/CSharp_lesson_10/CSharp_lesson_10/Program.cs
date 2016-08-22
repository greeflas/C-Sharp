/* Delegates */

using System;
using System.Linq;
using System.Threading;

namespace CSharp_lesson_10
{
    class Program
    {
        static void FlowOne()
        {
            for (int i = 0; i < 100; ++i)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Second flow]: {0}", i);
                Console.ResetColor();

                Thread.Sleep(1000);
            }
        }

        static void FlowTwo()
        {
            for (int i = 0; i < 100; ++i)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Third flow]: {0}", i);
                Console.ResetColor();

                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(
                new ThreadStart(FlowOne)
            );

            Thread t2 = new Thread(
                new ThreadStart(FlowTwo) 
            );

            t1.Priority = ThreadPriority.Normal;
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            for (int i = 0; i < 100; ++i)
            {
                Console.WriteLine("[Main flow]: {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
}
