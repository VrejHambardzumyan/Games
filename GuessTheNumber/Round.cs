namespace Games.GuessTheNumber
{
    public static class Round
    {
        private static int _max;
        private static int _min;
        private static int _rightGuessCount = 0;
        private static int _lives = 2;
    

        public static int generateNum(int min, int max)
        {
            return Random.Shared.Next(min, max + 1);
        }

        public static string Play2Rounds(Player player)
        {
            RoundInit();

            while (_lives > 0 && _rightGuessCount < 2)
            {
                Play(player,ref _rightGuessCount,ref _lives);
            }

            if (_rightGuessCount >= 2)
            {
                Console.WriteLine("You won the round but not the game :)");
                _lives = 2;
                _rightGuessCount = 0;
                return "Win";
            }
            else
            {
                Console.WriteLine("You lost the round but not the game :)");
                _lives = 2;
                _rightGuessCount = 0;
                return "Loose";
            }

        }   

        public static void Play(Player player,ref int rightGuessCount , ref int lives)
        {
            var numberInMind = generateNum(_min, _max);

                while (true)
                {
                    var guessedNum = player.Guess();
                    if (guessedNum == 404)
                    {
                        Console.WriteLine("Please enter a valid number:");
                    }
                    else
                    {
                        if (guessedNum == numberInMind)
                        {
                            Console.WriteLine("Congrats you guessed the number");
                            rightGuessCount++;                           
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Better luck next  time :(");
                            lives--;
                            break;
                        }

                    }

                }
        }
        public static void RoundInit()
        {
            while (true)
            {
                Console.WriteLine("Enter the range of numbers to guess(MAX range is [-300,300])");

                Console.Write("Begining:\t");
                while (!int.TryParse(Console.ReadLine(), out _min))
                {
                    Console.WriteLine("Invalid input, try again:");
                }

                Console.Write("End:\t");
                while (!int.TryParse(Console.ReadLine(), out _max))
                {
                    Console.WriteLine("Invalid input, try again:");
                }

                if (RangeCheck(_min, _max))
                {
                    Console.WriteLine($"Range set to [{_min},{_max}]");
                    break;
                }
                else
                {
                    Console.WriteLine("Numbers out of range");
                }
            }
        }
        private static bool RangeCheck(int min, int max)
        {
            if (min >= -300 && max <= 300 && min < max)
            {
                return true;
            }
            return false;
        }
    }
}