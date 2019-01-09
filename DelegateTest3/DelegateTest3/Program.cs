using System;

namespace DelegateTest3
{
    class Program
    {
        delegate int Calc(int i, int j);

        static void Main(string[] args)
        {
            //Calc c = new Calc(MySum);
            //Func<int, int, int> c = new Func<int, int, int>(MySum);
            //Func<int, int, int> c = MySum;
            //Console.WriteLine("1 + 2 = {0}", c(1, 2));

            Func<int, int, int> c1 = (i, j) => i + j;  // 식형식 람다 : 값을 리턴함
            //Calc c1 = delegate (int i, int j)
            //{
            //    return i + j;
            //};
            Console.WriteLine("3 + 4 = {0}", c1(3, 4));
        }
        //static int MySum(int i, int j)
        //{
        //    return i + j;
        //}
    }
}
