using System;

namespace P1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하십시오.");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하시오.");
            int age = int.Parse(Console.ReadLine());
            Console.Write("키를 입력하시오.");
            double cm = double.Parse(Console.ReadLine());

            Console.Write("안녕하세요, "+name+"님!\n");     
            Console.WriteLine("나이는 "+age+"세, 키는 "+cm+"cm 이군요!");
        }
    }
}
