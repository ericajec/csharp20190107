using System;

namespace EventTest1
{
    class EventPublisher
    {
        public delegate void MyEventHandler();
        public event MyEventHandler MyEvent,
        public void Do()
        {
            MyEvent?.Invoke();
        }
    }

    class Subscriber
    {
        static void ka
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
