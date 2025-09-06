

namespace Games
{
    public class Board
    {
        private char[] _board;

        public Board()
        {
            _board =
            [
                '1','2','3','4','5','6','7','8','9'
            ];
        }

        public void PrintBoard()
        {
            Console.Clear();
            for (int i = 0; i < _board.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
                Console.Write(_board[i]);
                Console.Write("\t");
            }
        }

        public bool IsFree(int index)
        {
            return _board[index] != Symbol.X && _board[index] != Symbol.O;
        }

        public void SetSymbol(char symbol, int index)
        {
            _board[index] = symbol;
        }

        public char GetSymbol(int index)
        {
            return _board[index];
        }
    }
}
