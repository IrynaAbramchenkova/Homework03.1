namespace GuessTheNumberGame
{
    //Write a console game. Program should generate random integer value and ask the user to guess it.
    //User has unlimited tries to guess the number. After the game, when the number is guessed, game should сalculate the result.
    //And ask user if they want to play again

    class NumberGuessingProgram
    {
        static void Main()
        {
            Random random = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                int numberToGuess = random.Next(1, 101);
                int guess=0;
                int validAttempts = 0;

                Console.WriteLine("Welcome! Try to guess the number between 1 and 100.");

                while (guess != numberToGuess)
                {
                    Console.Write("Enter your guess: ");
                    string input = Console.ReadLine();
                    //attempts++;

                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Invalid number. Please try again.");
                        continue;
                    }

                    if (guess > 100 || guess < 1)
                    {
                        Console.WriteLine("The number should be between 1 and 100. Please try again.");
                        continue;
                    }

                    validAttempts++;

                    if (guess < numberToGuess)
                    {
                        Console.WriteLine("The secret number is higher.");
                    }
                    else if (guess > numberToGuess)
                    {
                        Console.WriteLine("The secret number is lower.");
                    }
                    else
                    {
                        //Console.WriteLine("Congratulations, you guessed the number {0} in {1} attempts, {2} of which were valid!", numberToGuess, attempts, validAttempts);
                        Console.WriteLine("Congratulations, you guessed the number {0} in {1} Attempt!", numberToGuess, validAttempts);
                    }
                }

                Console.WriteLine("Do you want to play again? (Yes / No): ");
                string playAgainInput = Console.ReadLine().ToLower();

                while (playAgainInput != "yes" && playAgainInput != "no")
                {
                    Console.Write("Please enter Yes or No: ");
                    playAgainInput = Console.ReadLine().ToLower();
                }

                playAgain = (playAgainInput == "yes");
            }

            Console.WriteLine("Thanks for playing! Press any key to exit.");
            Console.ReadKey();
        }
    }
}