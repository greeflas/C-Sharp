/* Events */

using System;
using System.Linq;

namespace CSharp_lesson_10._1
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User("killer_vasya123", "Vasya", "Pupkin", "vasya@gmail.com");

            EventManager em = new EventManager();
            em.MyEvent += u1.Handler;

            // if(...) call event
            em.OnEventOccurred();
        }
    }
}
