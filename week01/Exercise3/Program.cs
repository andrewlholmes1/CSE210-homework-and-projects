using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        while (guess != magicNumber)
        {
            Console.Write("Guess the magic number (between 1 and 100): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess))
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You've guessed the magic number!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }
        }
    }
}