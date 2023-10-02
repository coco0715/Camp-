using System;

namespace SpecialLecture
{
    class Program_2
    {
        static void Main(string[] args)
        {
            // 1-2 간단한 사칙연산 계산기 만들기
            // 두 수를 입력 받고 사칙연산 결과 출력

            Console.Write("첫 번째 숫자를 입력하세요:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("두 번째 숫자를 입력하세요:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"더하기: {num1 + num2}");
            Console.WriteLine($"빼기: {num1 - num2}");
            Console.WriteLine($"곱하기: {num1 * num2}");
            Console.WriteLine($"나누기: {num1 / num2}");
        }
    }
}
