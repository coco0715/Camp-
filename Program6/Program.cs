namespace SpecialLecture
{
    class Program6
    {
        static void Main(string[] args)
        {
            // 2-2 별 찍기
            // 1. 오른쪽으로 기울어진 직각삼각형 출력
            // for 루프 사용 삼격형 높이 5
            Console.WriteLine("------------------");
            Console.WriteLine("1. 오른쪽으로 기울어진 직삼각형");
            char star = '*';

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("2. 역직각삼각형");

            // 2. 역직각삼각형 출력하기
            // 삼각형 높이 5
            // 5, 4, 3, 2, 1
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }

            // 3. 피라미드 출력하기
            // 피라미드 높이 5
            // 
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("3. 피라미드 출력하기");

            char blank = ' ';
            int count = 0;
            int kCount = 0;

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (j == i)
                    {
                        if (count > 1)
                        {
                            for (int k = i; k <= i + count; k++)
                            {
                                kCount++;
                                Console.Write(star);
                                if (k == i + count)
                                {
                                    j += kCount -1;
                                    kCount = 0;
                                }
                            }
                        }
                        else
                        {
                            Console.Write(star);
                        }
                    }
                    else
                    {
                        Console.Write(blank);
                    }
                    
                }
                count += 2;
                Console.WriteLine();
            }
        }
    }
}