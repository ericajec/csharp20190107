using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("출력을 원하는 구구단 단수 : ");

            int i, j, m;
            string str = Console.ReadLine();

            bool parsed = int.TryParse(str, out m);
            if (parsed)
            {
                Console.WriteLine();

                for (i = 2; i <= 9; i++)
                {
                    for (j = 1; j <= m; j++)
                    {
                        Console.Write($"{j}x{i} = {j * i}");
                        if (j < m)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
