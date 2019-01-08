using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 1; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write($" {i}");
                }
            }
            Console.WriteLine();
        }
    }
}
