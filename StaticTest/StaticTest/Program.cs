using System;

namespace StaticTest
{
    class Emp
    {
        public string name;
        public static string compName;
        public void GoToOffice()
        {
            Console.WriteLine($"{compName} 소속 {name}(이)가 출근합니다.");
        }
    }

    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp.compName = "탑크리에듀";
            Emp e = new Emp();
            e.name = "조은철";
            e.GoToOffice();
        }
    }
}
