﻿using System;

namespace ConstructorTest2
{
    class Emp
    {
        string name;
        //기본생성자, new할때 호출, 객체를 초기화
        public Emp()
        {
            name = "홍길이";
            Console.WriteLine("EMP 객체생성..." + name);
        }

        public Emp(string name)  //생성자, 생성자 오버로딩
        {
            this.name = name;
            Console.WriteLine("EMP 객체생성..." + name);
        }
    }

    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            Emp e1 = new Emp("광개토");
        }
    }
}
