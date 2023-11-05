class Solution
{
    // 플레이어 표식 안내 메서드
    public void PlayerMark()
    {
        Console.WriteLine("플레이어 1:X 와 플레이어 2:O");
        Console.WriteLine();
        Console.WriteLine();
    }

    // 플레이어 차례 안내 메서드
    public void PlayerTurnInfo(int i)
    {
        if ((i + 1) % 2 != 0) // for문 i 시작 값이 0이기 때문에 +1을 더해서 조건 검사
        {
            Console.WriteLine("플레이어 1의 차례");
            Console.WriteLine();
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("플레이어 2의 차례");
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    // 플레이어 입력 받는 메서드
    public void PlayerInput(int i, string[] tttBoard)
    {
        Console.Write("입력: ");
        int indexNum = int.Parse(Console.ReadLine());
        PlayerMarkingInput(i, tttBoard, indexNum);
    }

    // 플레이어가 입력 한 해당 인덱스에 해당 플레이어 표식을 저장해주는 메서드
    // 해당 플레이어를 구분하기 위해 for문에 사용되는 i값, tttBoard, indexNum을 매개변수로 전달 받는다.
    public void PlayerMarkingInput(int i, string[] tttBoard, int indexNum)
    {
        if ((i + 1) % 2 != 0) // for문 i 시작 값이 0이기 때문에 +1을 더해서 조건 검사
        {
            tttBoard[indexNum-1] = "X";
        }
        else
        {
            tttBoard[indexNum-1] = "O";
        }
    }

    // 틱텍토 게임판 메서드
    public void TicTecToeBoard(string[] tttBoard)
    {
        // 메인 메서드에서 배열의 값을 저장하고 값이 저장된 배열을 전달한다.
        // 이 메서드는 값이 변경된 게임판의 형태만을 출력해준다.

        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {tttBoard[0]}  |  {tttBoard[1]}  |  {tttBoard[2]}  ");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("-----|-----|-----");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {tttBoard[3]}  |  {tttBoard[4]}  |  {tttBoard[5]}  ");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("-----|-----|-----");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {tttBoard[6]}  |  {tttBoard[7]}  |  {tttBoard[8]}  ");
        Console.WriteLine("     |     |     ");
        Console.WriteLine();
        Console.WriteLine();
    }

    // 게임 승리자가 있는지 확인 후 있으면 게임 결과 & 게임 종료, 없다면 게임 진행 메서드
    // 게임 3회부터 출력하기 
    public bool GameManager(string[] tttBoard)
    {
        // 게임 승리자가 있는지 확인하기 
        // 게임 승리 조건식
        // 조건식 좀 더 짧게 만들어 보기
        // 1, 2, 3을 맞췄을 경우
        bool result = false;

        if (tttBoard[0] == "X" && tttBoard[1] == "X" && tttBoard[2] == "X")
        {
            Console.WriteLine("플레이어 1의 승리입니다.");
            result = true;
        }
        else if (tttBoard[0] == "O" && tttBoard[1] == "O" && tttBoard[2] == "O")
        {
            Console.WriteLine("플레이어 2의 승리입니다.");
            result = true;
        }
        // 4, 5, 6을 맞췄을 경우
        if (tttBoard[3] == "X" && tttBoard[4] == "X" && tttBoard[5] == "X")
        {
            Console.WriteLine("플레이어 1의 승리입니다.");
            result = true;
        }
        else if (tttBoard[3] == "O" && tttBoard[4] == "O" && tttBoard[5] == "O")
        {
            Console.WriteLine("플레이어 2의 승리입니다.");
            result = true;
        }
        // 7, 8, 9를 맞췄을 경우
        if (tttBoard[6] == "X" && tttBoard[7] == "X" && tttBoard[8] == "X")
        {
            Console.WriteLine("플레이어 1의 승리입니다.");
            result = true;
        }
        else if (tttBoard[6] == "O" && tttBoard[7] == "O" && tttBoard[8] == "O")
        {
            Console.WriteLine("플레이어 2의 승리입니다.");
            result = true;
        }
        // 1, 3, 7을 맞췄을 경우
        if (tttBoard[0] == "X" && tttBoard[2] == "X" && tttBoard[6] == "X")
        {
            Console.WriteLine("플레이어 1의 승리입니다.");
            result = true;
        }
        else if (tttBoard[0] == "O" && tttBoard[2] == "O" && tttBoard[6] == "O")
        {
            Console.WriteLine("플레이어 2의 승리입니다.");
            result = true;
        }
        // 2, 5, 8을 맞췄을 경우
        if (tttBoard[1] == "X" && tttBoard[4] == "X" && tttBoard[7] == "X")
        {
            Console.WriteLine("플레이어 1의 승리입니다.");
            result = true;
        }
        else if (tttBoard[1] == "O" && tttBoard[4] == "O" && tttBoard[7] == "O")
        {
            Console.WriteLine("플레이어 2의 승리입니다.");
            result = true;
        }
        // 3, 6, 9를 맞췄을 경우
        if (tttBoard[2] == "X" && tttBoard[5] == "X" && tttBoard[8] == "X")
        {
            Console.WriteLine("플레이어 1의 승리입니다.");
            result = true;
        }
        else if (tttBoard[2] == "O" && tttBoard[5] == "O" && tttBoard[8] == "O")
        {
            Console.WriteLine("플레이어 2의 승리입니다.");
            result = true;
        }
        // 1, 5, 9를 맞췄을 경우
        if (tttBoard[0] == "X" && tttBoard[4] == "X" && tttBoard[8] == "X")
        {
            Console.WriteLine("플레이어 1의 승리입니다.");
            result = true;
        }
        else if (tttBoard[0] == "O" && tttBoard[4] == "O" && tttBoard[8] == "O")
        {
            Console.WriteLine("플레이어 2의 승리입니다.");
            result = true;
        }
        // 3, 5, 7을 맞췄을 경우
        if (tttBoard[2] == "X" && tttBoard[4] == "X" && tttBoard[6] == "X")
        {
            Console.WriteLine("플레이어 1의 승리입니다.");
            result = true;
        }
        else if (tttBoard[2] == "O" && tttBoard[4] == "O" && tttBoard[6] == "O")
        {
            Console.WriteLine("플레이어 2의 승리입니다.");
            result = true;
        }
        return result;
    }
}
