using System;

namespace Random_Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;
            int numOfGuesses = 0;

            int rand = new Random().Next(1, 101);

            while (guess != rand)
            {
                numOfGuesses++;
                Console.WriteLine("Guess a number between 1 and 100");

                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess == rand)
                    {
                        Console.WriteLine("Correct guess");
                        Console.WriteLine($"You guessed {numOfGuesses} times");
                    }
                    else if (guess < rand)
                    {
                        Console.WriteLine("Wrong guess, too low");
                    }
                    else if (guess > rand)
                    {
                        Console.WriteLine("Wrong guess, too high");
                    }
                    Console.WriteLine($"You guessed {guess}");
                }
                else
                {
                    Console.WriteLine("Not a number");
                }
            }
        }
    }
}
