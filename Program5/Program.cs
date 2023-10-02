namespace SpecialLecture
{
    class Program5
    {
        static void Main(string[] args) {
            // 2-1 구구단 출력하기
            int i = 2;
            int j = 1;
            while(i <= 9)
            {
               while(j <= 9)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                    j++;
                }
                j = 1;
                i++;
            }
        }
    }
}