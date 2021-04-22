/*
 * HiLo
 * Version 1.0
 * By Anne-Marie Charles-Nguyen
 */
/// <summary>
/// HiLo
/// Version 1.0
/// By Anne-Marie Charles-Nguyen
/// </summary>

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            Boolean end = false;
            Boolean found = false;
            
            while (!end)
            {
                var nbrToGuess = rand.Next(1, 100);
                Console.Write("Welcome to HiLo. Please input a number between 1 and 100: ");
                int guessedNbr;

                for (int i = 0; i < 10; i++)
                {
                    var guess = Int32.TryParse(Console.ReadLine(), out guessedNbr);
                    if (guess)
                    {
                        Console.WriteLine($"You have input: {guessedNbr}");
                        if (guessedNbr == nbrToGuess)
                        {
                            Console.WriteLine("You have found the right number! Game over.");
                            found = true;
                            break;
                        }
                        else if (guessedNbr < nbrToGuess)
                        {
                            Console.WriteLine("The magic number is higher.");
                        }
                        else if (guessedNbr > nbrToGuess)
                        {
                            Console.WriteLine("The magic number is lower.");
                        }
                    } else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    Console.Write("Please input your guess: ");
                }

                if (!found)
                {
                    Console.WriteLine("You haven't found the magic number. Game over.");
                }

                Console.Write("Play again? (y/n): ");
                var answer = Console.ReadLine();
                Boolean validInput = false;
                while (!validInput)
                {
                    if (answer == "y")
                    {
                        end = false;
                        validInput = true;
                    }
                    else if (answer == "n")
                    {
                        end = true;
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                        validInput = false;
                    }
                }

            }
        }

    }
}
