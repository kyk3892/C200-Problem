using System;

namespace P1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            float flt = 1F / 3;
            double db1 = 1D / 3;
            decimal dcm = 1M / 3;

            //크기를 바이트 단위로 리턴
            Console.WriteLine("float : {0}\ndouble : {1}\ndecimal : {2}",flt, db1,dcm);
            Console.WriteLine("float : {0} bytes\ndouble : {1} bytes\ndecimal : {2} bytes", sizeof(float), sizeof(double), sizeof(decimal));

            //각 각의 최댓값과 최솟값
            Console.WriteLine("float : {0}~{1}", float.MinValue,float.MaxValue);
            Console.WriteLine("double : {0}~{1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal : {0}~{1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}
