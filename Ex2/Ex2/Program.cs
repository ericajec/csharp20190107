using System;
namespace ConsoleApplication1
{
    class Rtype
    {
        public object Value;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rtype a = new Rtype();
            Rtype b = new Rtype();

            a.Value = 1; b = a; //a가 참조하는 것을 b도 참조한다.
            Console.WriteLine(a.Value); Console.WriteLine(b.Value);

            b.Value = 2;
            Console.WriteLine(a.Value); Console.WriteLine(b.Value);
        }
    }
}
