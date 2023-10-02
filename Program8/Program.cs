namespace SpecialLecture
{
    class Program8
    {
        static void Main(string[] args)
        {
            // 2-4 소수 판별하기 
            // 소수인지 아닌지 판별
            Console.Write("숫자를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());    

            if (IsPrime(num))
            {
                Console.WriteLine($"{num}은 소수입니다.");
            }
            else
            {
                Console.WriteLine($"{num}은 소수가 아닙니다.");
            }
        }

        static bool IsPrime(int num)
        {
            bool answer = false;
      
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (Math.Sqrt(num) % i == 0)
                {
                    answer = false;
                }
                else
                {
                    answer = true;
                }
            }
            return answer;
        }
    }
}