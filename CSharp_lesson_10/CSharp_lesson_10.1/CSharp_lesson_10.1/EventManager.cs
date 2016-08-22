using System;
using System.Linq;

namespace CSharp_lesson_10._1
{
    class EventManager
    {
        public event MyDelegate MyEvent;

        public void OnEventOccurred()
        {
            MyEvent();
        }
    }
}
