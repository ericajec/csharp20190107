using System;

namespace ValueRefTest
{
    class Emp
    {
        public string name;

    }

    class Program
    {
        static void Main(string[] args)
        {
            // int i = 999;
            int i = new int();
            i = 999;
            Emp e = new Emp();
            e.name = "홍길동";
        }
    }
}
