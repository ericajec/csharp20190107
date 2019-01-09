using System;

namespace InexerTest
{
    class Emp
    {
        private string[] hobbies = new stirng[3];
        public string this[int index]
        {
            get
            {
                return hobbies[index];
            }
            set
            {
                hobbies[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e[0] = "등산"; e[1] = "축구"; e[2] = "골프";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"e[i]");
            }
        }
    }
}
