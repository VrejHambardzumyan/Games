namespace Games.GuessTheNumber
{
    public class Player
    {
        public string Name { get; set; }

        public int Guess()
        {
            Console.WriteLine("Try guessing ");
            var consoleKey = Console.ReadLine();
            if( int.TryParse(consoleKey, out int guess))
            {
                return guess;
            }
            else
            {
                return 404 ;
            }
            
        }
    }
}
