namespace MastermindOneMoreCompressed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = new Random().Next(0, 1000);
            int guess;
            for (int numberOfGuesses = 1; ; numberOfGuesses++)
            {
                Console.WriteLine("Your guess?\n(A nonnegative integer of maximum three digits)");
                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 0 || guess > 999 || guess == numberToGuess)
                {
                    if (guess < 0 || guess > 999) Console.WriteLine("Guess is not in specified interval.");
                    else if (guess != numberToGuess) Console.WriteLine("Incorrect number format.");
                    else Console.WriteLine($"You won by {numberOfGuesses} guess" + (numberOfGuesses > 1 ? "es" : "") + ".");
                    if (guess == numberToGuess) return;
                }
                if (guess / 100 < numberToGuess / 100) Console.WriteLine("First digit is too small.");
                else if (guess / 100 > numberToGuess / 100) Console.WriteLine("First digit is too large.");
                else Console.WriteLine($"First digit is correct: {guess / 100}");
                if (guess % 100 / 10 < numberToGuess % 100 / 10) Console.WriteLine("Second digit is too small.");
                else if (guess % 100 / 10 > numberToGuess % 100 / 10) Console.WriteLine("Second digit is too large.");
                else Console.WriteLine($"Second digit is correct: {guess % 100 / 10}");
                if (guess % 10 < numberToGuess % 10) Console.WriteLine("Third digit is too small.");
                else if (guess % 10 > numberToGuess % 10) Console.WriteLine("Third digit is too large.");
                else Console.WriteLine($"Third digit is correct: {guess % 10}");
            }
        }
    }
}