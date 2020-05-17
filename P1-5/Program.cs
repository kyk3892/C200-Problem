using System;

namespace P1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "h";
            b = b + "ello";
            Console.WriteLine(a==b); //true 나옴
            Console.WriteLine("b = " + b);
            int x = 10;
            string c = b + '!' + " " + x;
            Console.WriteLine("c = " + c);
        }
    }
}
