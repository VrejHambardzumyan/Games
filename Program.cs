using Games.TicTacToe;
using Games.GuessTheNumber;
using Games.AbstarctGame;
namespace Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose game: TicTacToe(1) or GuessTheNumber(2)");
            var choice = Console.ReadLine();

            BaseGame selectedGame;

            switch (choice)
            {
                case "1":
                    selectedGame = new TicTacToeGame();
                    break;
                case "2":
                    selectedGame = new GuessTheNumberGame();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }


            selectedGame.StartGame();
        }
    }
}
