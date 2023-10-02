using System;

namespace AliSalmeh_ProjectWeek5_MiniGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mini Game

            Random random = new Random();
            bool playAgain = true;

            do
            {
                Console.Clear();

                int computerRandomNum = random.Next(1, 101);
                int userGuess = 0;
                int round = 0;

                while (userGuess != computerRandomNum)
                {
                    Console.WriteLine("Guess a number between 1 - 100 :");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Guess: {userGuess}");

                    if (userGuess > 100 || userGuess < 0)
                    {
                        Console.WriteLine("You entered invalid number!!");
                    }
                    else if (userGuess < computerRandomNum)
                    {
                        Console.WriteLine($"{userGuess} is too low!");
                    }
                    else if (userGuess > computerRandomNum)
                    {
                        Console.WriteLine($"{userGuess} is too high!");
                    }
                    round++;
                }

                Console.WriteLine();
                Console.WriteLine("YOU WIN *__*");
                Console.WriteLine($"Round: {round}");
                Console.WriteLine();
                Console.WriteLine("Would you like to play again? (Y/N): ");

                var userAns = Console.ReadLine().ToUpper();
                playAgain = userAns == "Y" ? true : false;

            } while (playAgain);

            Console.WriteLine("Thanks for playing! ... ^__^");
        }
    }
}