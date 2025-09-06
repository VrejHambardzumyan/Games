using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        private Board _board;

        public void StartGame()
        {
            InitializePlayers();
            InitializeBoard();

            _board.PrintBoard();
            int i = 0;
            while (true)
            {
                PlayerMove(_player1);
                i++;
                Console.Clear();
                _board.PrintBoard();
                if (i >= 5 && Rules.HasWinner(_board))
                {
                    Console.WriteLine($"Player {_player1.Name} wins!");
                    break;
                }

                if (i == 9)
                {
                    Console.WriteLine("Draw!");
                    break;
                }

                PlayerMove(_player2);
                i++;
                Console.Clear(); // Clean the console
                _board.PrintBoard();

                if (Rules.HasWinner(_board))
                {
                    Console.WriteLine($"Player {_player2.Name} wins!");
                    break;
                }
            }
        }

        public void PlayerMove(Player player)
        {
            Console.Write($"Player {player.Name} move: ");
            var input = player.Move();
            if (input == -1)
            {
                Console.WriteLine("Invalid move");
                PlayerMove(player);
                return;
            }

            if (!_board.IsFree(input))
            {
                Console.WriteLine("Cell is already occupied");
                Thread.Sleep(1000);
                PlayerMove(player);
                return;
            }

            _board.SetSymbol(player.Symbol, input);
        }


        private void InitializePlayers()
        {
            Console.WriteLine("Please choose the player 1 type");
            Console.WriteLine("1. Human");
            Console.WriteLine("2. AI");
            var input = Console.ReadKey();
            Console.WriteLine();
            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("Please enter the player name for X");
                var player1Name = Console.ReadLine();
                _player1 = new Player()
                {
                    Name = player1Name,
                    Symbol = Symbol.X
                };
            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                _player1 = new AIPlayer()
                {
                    Name = "AI 1",
                    Symbol = Symbol.X
                };
            }

            Console.WriteLine("Please choose the player 2 type");
            Console.WriteLine("1. Human");
            Console.WriteLine("2. AI");
            input = Console.ReadKey();
            Console.WriteLine();
            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("Please enter the player name for X");
                var player2Name = Console.ReadLine();
                _player2 = new Player()
                {
                    Name = player2Name,
                    Symbol = Symbol.O
                };
            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                _player2 = new AIPlayer()
                {
                    Name = "AI 2",
                    Symbol = Symbol.O
                };
            }
        }

        private void InitializeBoard()
        {
            _board = new Board();
        }



    }
}
