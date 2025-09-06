namespace Games.TicTacToe
{
    public static class Rules
    {
        private static int[,] possibleWins = new int[8, 3]
        {
        {0,1,2},
        {3,4,5},
        {6,7,8},
        {0,3,6},
        {1,4,7},
        {2,5,8},
        {0,4,8},
        {2,4,6},
        };

        public static bool HasWinner(Board board)
        {
            for (int i = 0; i < possibleWins.GetLength(0); i++)
            {
                if (board.GetSymbol(possibleWins[i, 0]) == board.GetSymbol(possibleWins[i, 1])
                    && board.GetSymbol(possibleWins[i, 0]) == board.GetSymbol(possibleWins[i, 2]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasDraw(Board board)
        {
            for (int i = 0; i < 9; i++)
            {
                var index = board.GetSymbol(i);
                if (index != Symbol.X && index != Symbol.O)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
