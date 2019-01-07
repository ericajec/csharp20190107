namespace AsTest
{
    class Emp
    {
        public override string
       ToString()
        {
            return "Emp";
        }
    }
    class Programmer : Emp { }
    class Program
    {
        static void Main()
        {
            Programmer p = new Programmer();

            if(p is Emp)
            {
                System.Console.WriteLine("p is Emp");
            }
//            Emp e = p as Emp;
            Emp e = (Emp)p;
            if (e != null)
                System.Console.WriteLine(e.ToString());
        }
    }
}