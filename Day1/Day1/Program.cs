using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                short a = 10;
                int b = a;
                int c = 50000;

                Console.WriteLine("Short : {0}, {1}, {2}", a,b,c);
                Console.WriteLine($"Short : {a}, {b}, {c}");
                short d = checked((short)c);
//                Console.WriteLine("Short : {0}", d);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
