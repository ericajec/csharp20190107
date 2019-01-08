using System;
using Shapes;

namespace ShapesUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(8);
            Console.WriteLine($"반지름이 8인 원의 면적:{c.Area()}");
        }
    }
}
