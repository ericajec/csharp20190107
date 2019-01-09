#define SOUNDCARD
using System;
using System.Diagnostics;

namespace SoundCard
{
    class Program
    {
        [Conditional("SOUNDCARD")]
        static void print()
        {
            Console.WriteLine("도레미...");
        }

        static void Main(string[] args)
        {
            print();
        }
    }
}
