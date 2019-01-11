using System;
using System.Threading;

namespace ThreadTest4
{
    public class ThreadTest4
    {
        public string lockString = "Hello";
        private static Mutex mutex = new Mutex();
        //private object obj = new object();
        public void Print(string rank)
        {
            //lock(obj)
            mutex.WaitOne();
                for(int i=0; i<5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Thread.Sleep(100);
                        Console.Write("");
                    }
                Console.WriteLine("{0}{1} ", rank, lockString);
            }
            mutex.ReleaseMutex();
        }
        public void FirstWork() { Print("F"); }
        public void SecondWork() { Print("S"); }
    }

    class Program
    {
        [MTAThread]
        public static void Main()
        {
            ThreadTest4 t = new ThreadTest4();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            Thread second = new Thread(new ThreadStart(t.SecondWork));

            first.Start();
            second.Start();
        }
    }
}
