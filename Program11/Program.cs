    class Program
    {
        static void Main(string[] args) 
        {
            // 플레이어의 번호 선택으로 매 게임 판마다 갱신되는 틱택토 보드 값 표현을 위해 게임 초기에 게임판 배열 선언 후 초기화
            string[] tttBoard = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int i = 0; // 현재 게임 턴 변수
            bool result = false; // 게임 결과 값 저장 변수
            
            Solution sl = new Solution();

            for(i = 0; i < tttBoard.Length; i++)
            {
                sl.PlayerMark();
                sl.PlayerTurnInfo(i);
                sl.TicTecToeBoard(tttBoard);
                sl.PlayerInput(i, tttBoard);

                if(i >= 2)
                {
                   result = sl.GameManager(tttBoard);
                   if (result)
                    {
                        break;
                    }
                }
            }
        }
    }
