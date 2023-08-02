namespace MastermindIn41Rows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = new Random().Next(0, 1000);
            int numberOfGuesses = 0;
            int guess;

            do
            {
                Console.WriteLine("Your guess?\n(A nonnegative integer of maximum three digits)");

                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 0 || guess > 999)
                {
                    if (guess < 0 || guess > 999) Console.WriteLine("Guess is not in specified interval.");
                    else Console.WriteLine("Incorrect number format.");
                }
                numberOfGuesses++;

                if (guess != numberToGuess)
                {
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
            } while (guess != numberToGuess);

            Console.WriteLine($"You won by {numberOfGuesses} guess" + (numberOfGuesses > 1 ? "es" : string.Empty) + ".");
        }
    }
}