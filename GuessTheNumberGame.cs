namespace GuessTheNumberGame
{
    class GuessTheNumberGame
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // Генериране на число между 1 и 100
            int guessCount = 0;
            bool guessed = false;

            Console.WriteLine("Welcome to the Guess the Number game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (!guessed)
            {
                Console.Write("Take a guess: ");
                int userGuess = int.Parse(Console.ReadLine());
                guessCount++;

                if (userGuess == secretNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed it in {guessCount} tries.");
                    guessed = true;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                else
                {
                    Console.WriteLine("Too high. Try again.");
                }
            }
        }
    }
}