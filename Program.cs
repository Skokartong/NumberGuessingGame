using System;
using System.ComponentModel.Design;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to the number guessing game! You get to choose the difficulty level.");
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Choose the minimum value for the number you want to guess (e.g., 0 or 1):");
                int min = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose the maximum value for the number you want to guess (e.g., 50):");
                int max = int.Parse(Console.ReadLine());

                Random random = new Random();
                int number = random.Next(min, max);

                Console.WriteLine("How many attempts do you want to guess correctly? Please respond with a number:");
                int guesses = int.Parse(Console.ReadLine());

                for (int i = 0; i < guesses; i++)
                {
                    Console.WriteLine("Enter your guess:");
                    int guess = int.Parse(Console.ReadLine());

                    if (guess < min || guess > max)
                    {
                        Console.WriteLine("You guessed outside your range of numbers, try again!");
                    }
                    else if (guess == number)
                    {
                        Console.WriteLine("Congratulations, you guessed correctly!");
                        break;
                    }
                    else if (guess - number > 0 && guess - number < 5)
                    {
                        Console.WriteLine("You guessed a bit too high, but close!");
                    }
                    else if (number - guess > 0 && number - guess < 5)
                    {
                        Console.WriteLine("You guessed a bit too low, but close!");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("You guessed too high, try again!");
                    }
                    else
                    {
                        Console.WriteLine("You guessed too low, try again!");
                    }
                }

                Console.WriteLine("The number was: " + number);
                Console.WriteLine("Do you want to play again (Y/N)?");
                string playAgainResponse = Console.ReadLine();

                if (playAgainResponse == "N")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thank you for playing! :)");
        }
    }
}