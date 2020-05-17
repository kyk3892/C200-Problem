using System;

namespace P1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 이하의 소수: {0}, {1}, {2}, {3}", 2, 3, 5, 7);

            string primes;
            primes = String.Format("10 이하의 소수: {0}. {1}, {2}, {3}", 2, 3, 5, 7); //String.Format() 메소드를 사용하면 Console.WrtieLine()과 똑같은 방법
            Console.WriteLine(primes);
        }
    }
}
