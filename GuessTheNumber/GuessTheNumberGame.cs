using Games.AbstarctGame;

namespace Games.GuessTheNumber
{
    public class GuessTheNumberGame : BaseGame
    {
        private Player _player;
        private int _correctGuess = 0;
        private int _falseGuess  = 0;

        public override void StartGame()
        {
            PlayerInit();
            while (_correctGuess != 5 && _falseGuess != 5)
            {

                if (Round.Play2Rounds(_player) == "Win")
                {
                    _correctGuess++;
                }
                else
                {
                    _falseGuess++;
                }
                Console.WriteLine($"Score:\tComputer:{_falseGuess},\t{_player.Name}:{_correctGuess}");
            }
            if (_correctGuess == 5)
            {
                Console.WriteLine("Congratulations, you won the game!!!");
            }
            else
            {
                Console.WriteLine("This was a sign to not go pro on gambling");
            }
        }

       private void  PlayerInit()
        {
            Console.WriteLine("Enter the players name");
            var name = Console.ReadLine();
            _player = new Player { Name = name };
        }

    }
}
