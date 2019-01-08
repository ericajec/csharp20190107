using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력숫자:");
            string str = Console.ReadLine();
            int i, m;
            int sum = 0;

            bool parsed = int.TryParse(str, out m);

            if (parsed)
            {
                for (i = 1; i <= m; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }
//                Console.WriteLine($"입력숫자:{m}");
                Console.WriteLine($"{m}까지의 짝수의 합은:{sum}");
            }
        }
    }
}
