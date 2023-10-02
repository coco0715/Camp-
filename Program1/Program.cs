namespace SpacialLecture
{
    class Program_1
    {
        static void Main(string[] args)
        {
            // 1-1 사용자로부터 입력 받기
            Console.Write("이름을 입력하세요: ");
            string name = Console.ReadLine();

            Console.Write("나이를 입력하세요: ");
            string age = Console.ReadLine();

            Console.WriteLine($"안녕하세요 , {name}! 당신은 {age} 세 이군요!");
        }
    }
}
