using System;

namespace Ex14
{
    class Program
    {
        static int Calc(int j, int k)
        {
            return j / 10;
        }

        static void Main(string[] args)
        {
            int i, j, k, cnt = 0;

            for (i=1; i<=10000; i++)
            {
                j = i;
                k = 1;

                do
                {
                    if (j % 10 == 7) cnt++;
                    j = Calc(j, k);
                    k++;
                }
                while (j > 0);
            }
            Console.WriteLine($"Cnt : {cnt}");
        }
    }
}
