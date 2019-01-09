using System;

namespace DeligateTest
{
    class Program
    {
        //delegate int SumDelegate(int i, int j);

        static void Main(string[] args)
        {
            Program p = new Program();
            Func<int, int, int> s = p.Sum;
            Console.WriteLine(s(11, 27));
        }
        int Sum(int i, int j)
        {
            return i + j;
        }
    }
}
