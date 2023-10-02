using System;

namespace SpecialLecture
{
    class Program_4
    {
        static void Main(string[] args)
        {
            // 1-4 BMI 지수 만들기

            Console.Write("키(cm)를 입력하세요: ");
            double num1 = double.Parse(Console.ReadLine());

            num1 = num1 / 100;

            Console.Write("체중을 입력하세요: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"당신의 BMI 지수는: {num2 / (num1 * num1)}");
        }
   }
}
