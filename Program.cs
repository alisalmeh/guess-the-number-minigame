using System;

namespace AliSalmeh_ProjectWeek5_MiniGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            do
            {
                Console.Clear();
                playAgain = PlayGame();

            } while (playAgain);

            Console.WriteLine("\nThanks for playing! ... ^__^");
        }

        static bool PlayGame()
        {
            Random random = new Random();
            int computerRandomNum = random.Next(1, 101);
            int userGuess = 0;
            int round = 0;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Guess a number between 1 - 100 :");

                try
                {
                    userGuess = GetUserInputAsInt();
                    Console.WriteLine($"Guess: {userGuess}");

                    if (userGuess < computerRandomNum)
                    {
                        Console.WriteLine($"{userGuess} is too low!");
                    }
                    else if (userGuess > computerRandomNum)
                    {
                        Console.WriteLine($"{userGuess} is too high!");
                    }

                    round++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

            } while (userGuess != computerRandomNum);

            PrintResultInformation(round);

            var userAns = Console.ReadLine().ToLower();
            return userAns == "y";
        }

        static void PrintResultInformation(int round)
        {
            Console.WriteLine();
            Console.WriteLine("YOU WIN *__*\n" +
                                $"Round: {round}\n" +
                                "Would you like to play again? (Y/N): ");
        }

        static int GetUserInputAsInt()
        {
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < 1 || userInput > 100)
            {
                throw new Exception("Number is  out of range! Please enter a valid number: ");
            }

            return userInput;
        }
    }
}