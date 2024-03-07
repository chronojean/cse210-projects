using System;

class Program
{
    static void Main(string[] args)
    {
        string repeat = "Y";
        while (repeat.ToUpper() == "Y")
        {
            Random rnd = new Random();
            int magicNumber = rnd.Next(1, 20); // Generate a random number between 1  and 20 (inclusive).
            int tries = 0;
            Console.WriteLine("Welcome to the Magic Number Game!");
            while (true)
            {
                tries++;
                Console.Write("Enter your guess: ");
                int userGuess = int.Parse(Console.ReadLine());

                if (magicNumber == userGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congratulations! You guessed the right number ({magicNumber}).");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    string clue = userGuess > magicNumber ? "too high!" : "too low!";
                    Console.WriteLine($"Sorry, {clue} Your turn again.");
                    Console.ResetColor();
                }
            }
            if (tries == 1)
            {
                Console.WriteLine("You did it in the first try. That's amazing! Keep up the good work.");
            }
            else
            {
                Console.WriteLine($"It took you {tries} tries to guess the correct number.");
            }
            Console.Write("\nDo you want to play again? Y/N: ");
            repeat = Console.ReadLine().Trim().ToUpper();
        }
    }
}

