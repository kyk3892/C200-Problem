using System;

namespace P1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 100;
            double v2 = 1.234;

            //Console.WriteLine(v1, v2) - 오류
            Console.WriteLine(v1.ToString()+", "+v2.ToString());
            Console.WriteLine("v1 = "+v1+", v2 = "+v2); //각각 문자열로 바꾸어 연결
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2); //형식 정보를 사용
            Console.WriteLine($"v1 = {v1}, v2 = {v2}"); //형식 문자열 앞에 $기호 사용
        }
    }
}
