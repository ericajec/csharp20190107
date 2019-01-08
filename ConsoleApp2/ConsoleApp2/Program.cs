using System;

namespace PTest
{
    partial class Emp
    {
        public void GoToOffice()
        {
            Console.WriteLine("사원 출근 ...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.GoToOffice();
            e.GoToOff();
        }
    }
}
