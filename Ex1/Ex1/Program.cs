﻿using System;

class Program
{
    static void Main()
    {
        int? a = null;

        int b;

        if (a.HasValue) b = a.Value;
        else b = 0;

        Console.WriteLine("Value of b is {0}", b);

        int c = a ?? 0;

        Console.WriteLine("Value of c is {0}", c);
        Console.ReadLine();
    }
}