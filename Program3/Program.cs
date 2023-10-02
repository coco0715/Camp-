using System;

namespace SpecialLecture
{
    class Program_3
    {
        static void Main(string[] args)
        {
            // 1-3 온도 변환기 만들기

            //섭씨 온도 입력받기
            Console.Write("섭씨 온도를 입력하세요: ");
            float num = float.Parse(Console.ReadLine());
            // 화씨 온도 출력하기
            Console.WriteLine($"변환된 화씨 온도: {(num * 9 / 5) + 32}");
        }
    }
}
