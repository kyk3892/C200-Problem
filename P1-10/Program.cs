using System;

namespace P1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("standard Numeric Format Specifiers");
            Console.WriteLine(
                "(C) Currency: ......{0:C}\n" +
                "(D) Decimal: ......{0:D}\n" +
                "(E) Scientific: ......{1:E}\n" +
                "(F) Fixed point: ......{1:F}\n" +
                "(G) General: ......{0:G}\n" +
                "(N) Numer: ......{0:N}\n" +
                "(P) Percent: ......{1:P}\n" +
                "(R) Round-trip: ......{1:R}\n" +
                "(X) Hexadecimal: ......{0:X}\n",
                -12345678, -1234.5687f);

            decimal value = 123456.789m;
            Console.WriteLine("잔액은 {0:C2}은 입니다.", value); //통화 형식으로 소수점 아래 두 자리로 출력
            Console.WriteLine("잔액은 {0,20:C2}원 입니다.", value); // 20자리 중 앞쪽의 사용되지 않는 부분은 빈칸으로 나타냄
        }
    }
}
