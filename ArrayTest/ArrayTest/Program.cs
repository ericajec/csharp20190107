using System;

class ArrayTest
{
    static void Main(string[] args)
    {
        int[][] arr = new int[2][];

        arr[0] = new int[5] { 1, 3, 5, 7, 9 };
        arr[1] = new int[4] { 2, 4, 6, 8 };

        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.WriteLine("Element({0}) : ", i);
            for (int j = 0; j < arr[i].Length; j++)
            {
                System.Console.WriteLine("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }
}
