namespace Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            int numberToGuess = random.Next(0, 1000);
            int numberOfGuesses = 0;
            int guess;

            do
            {
                Console.WriteLine("Your guess?\n(A nonnegative integer of maximum three digits)");

                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 0 || guess > 999)
                {
                    if (guess < 0 || guess > 999)
                    {
                        Console.WriteLine("Guess is not in specified interval.");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number format.");
                    }
                }
                numberOfGuesses++;

                if (guess != numberToGuess)
                {
                    int unitsDigitNumberToGuess = numberToGuess % 10;
                    int tensDigitNumberToGuess = numberToGuess % 100 / 10;
                    int hundredsDigitNumberToGuess = numberToGuess / 100;

                    int unitsDigitGuess = guess % 10;
                    int tensDigitGuess = guess % 100 / 10;
                    int hundredsDigitGuess = guess / 100;

                    if (hundredsDigitGuess < hundredsDigitNumberToGuess)
                    {
                        Console.WriteLine("First digit is too small.");
                    }
                    else if (hundredsDigitGuess > hundredsDigitNumberToGuess)
                    {
                        Console.WriteLine("First digit is too large.");
                    }
                    else
                    {
                        Console.WriteLine($"First digit is correct: {hundredsDigitGuess}");
                    }
                    if (tensDigitGuess < tensDigitNumberToGuess)
                    {
                        Console.WriteLine("Second digit is too small.");
                    }
                    else if (tensDigitGuess > tensDigitNumberToGuess)
                    {
                        Console.WriteLine("Second digit is too large.");
                    }
                    else
                    {
                        Console.WriteLine($"Second digit is correct: {tensDigitGuess}");
                    }
                    if (unitsDigitGuess < unitsDigitNumberToGuess)
                    {
                        Console.WriteLine("Third digit is too small.");
                    }
                    else if (unitsDigitGuess > unitsDigitNumberToGuess)
                    {
                        Console.WriteLine("Third digit is too large.");
                    }
                    else
                    {
                        Console.WriteLine($"Third digit is correct: {unitsDigitGuess}");
                    }
                }
            } while (guess != numberToGuess);

            Console.WriteLine($"You won by {numberOfGuesses} guess" + (numberOfGuesses > 1 ? "es" : string.Empty) + ".");
        }
    }
}