namespace SpecialLecture
{
    class Program7
    {
        static void Main(string[] args)
        {
            //2-3 최대값, 최소값 찾기
            // 숫자를 입력 받고 그 중 최대값과 최소값을 찾기
            int[] inputNum = new int[5];
            int min = 0;
            int max = 0;

            for (int i = 0; i < inputNum.Length; i++ )
            {
                Console.Write("숫자를 입력하세요: ");
                inputNum[i] = int.Parse( Console.ReadLine() );
            }

            Array.Sort(inputNum);
            min = inputNum[0];

            Array.Reverse(inputNum);
            max = inputNum[0];

            Console.WriteLine($"최대값: {max}");
            Console.WriteLine($"최소값: {min}");
        }
    }
}