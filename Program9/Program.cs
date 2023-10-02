namespace SpacialLecture
{
    class Program9
    {
        static void Main(string[] args)
        {
            // 2-5 숫자 맞추기
            // 1부터 100까지 숫자중 임의의 숫자 맞추기
            // 1부터 100까지 숫자중 랜덤하게 하나 저장
            // 저장된 숫자보다 크면 너무 큽니다
            // 저장된 숫자보다 작으면 너무 작습니다 출력
            // 저장된 숫자를 맞추면 게임 종료
            
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int inputNum = 0;
            int count = 0;

            for (int i = 0; i < 100; i++)
            {
                count++;
                Console.Write("숫자를 맞추세요: ");
                inputNum = int.Parse(Console.ReadLine());   

                if (inputNum == numberToGuess)
                {
                    Console.WriteLine($"축하합니다! {count}번 만에 숫자를 맞추었습니다!");
                    break;
                }
                else if (inputNum > numberToGuess)
                {
                    Console.WriteLine("숫자가 너무 큽니다.");
                }
                else
                {
                    Console.WriteLine("숫자가 너무 작습니다.");
                }
            }
        }
    }
}