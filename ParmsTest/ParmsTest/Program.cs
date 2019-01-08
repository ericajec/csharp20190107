using System;

namespace ParmsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1,2,3,4,5,6,7,8,9,10));
            Console.WriteLine(Sum(1, 2, 3, 4, 5));
            Console.WriteLine(Sum(new int[] { 1, 2, 3 }));
        }

        static int Sum(params int[] iArr)
        {
            int sum = 0;
            foreach(int i in iArr)
            {
                sum += i;
            }
            return sum;
        }
    }
}
