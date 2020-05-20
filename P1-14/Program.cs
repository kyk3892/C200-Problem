using System;

namespace P1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.Write("1. int로 변한할 문자열을 입력하세요: ");
            string input = Console.ReadLine();
            Boolean result = Int32.TryParse(input, out value); //input을 정수 value로 변환

            if (!result)
            {
                Console.WriteLine("'{0}'는 int로 변환될 수 없습니다.\n",input);
            }
            else
            {
                Console.WriteLine("int '{0}'으로 변환되었습니다.\n",value);
            }

            Console.Write("2. double로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();
            try
            {
                double m = Double.Parse(input);
                Console.WriteLine("double '{0}'으로 변환되었습니다.\n",m);
            }
            catch(FormatException a)
            {
                Console.WriteLine(a.Message);
            }

        }
    }
}
