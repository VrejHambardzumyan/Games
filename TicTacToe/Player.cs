namespace Games.TicTacToe
{
    public class AIPlayer : Player
    {
        public override int Move()
        {
            var index = Random.Shared.Next(0, 9);
            return index;
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public char Symbol { get; set; }

        public virtual int Move()
        {
            var consoleKey = Console.ReadKey();

            switch (consoleKey.Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    {
                        return 0;
                    }
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    {
                        return 1;
                    }
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    {
                        return 2;
                    }
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    {
                        return 3;
                    }
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    {
                        return 4;
                    }
                case ConsoleKey.NumPad6:
                case ConsoleKey.D6:
                    {
                        return 5;
                    }
                case ConsoleKey.NumPad7:
                case ConsoleKey.D7:
                    {
                        return 6;
                    }
                case ConsoleKey.NumPad8:
                case ConsoleKey.D8:
                    {
                        return 7;
                    }
                case ConsoleKey.NumPad9:
                case ConsoleKey.D9:
                    {
                        return 8;
                    }
            }

            return -1;
        }
    }
}
