﻿using System;

namespace P1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.WriteLine("Worldl!");
            Console.Write("이름을 입력하세요: ");

            string name = Console.ReadLine();
            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");
        }
    }
}
