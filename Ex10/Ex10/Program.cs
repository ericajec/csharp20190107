using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 10 numbers:");
            Console.WriteLine();

            int i, m;
            int sum = 0;

            for (i = 1; i <= 10; i++)
            {
                Console.Write($"숫자-{i}:");
                string str = Console.ReadLine();

                bool parsed = int.TryParse(str, out m);
                if (parsed)
                {
                    sum += m;
                }
            }

            Console.WriteLine($"합:{sum}");
            Console.WriteLine($"평균:{sum/10}");
        }
    }
}
