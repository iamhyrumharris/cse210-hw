using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNum = new Random();
        int magicNumber = randomNum.Next(1, 100);
        int guessNumber = -1;
        int guessesCount = 0;
        string playAgain = "y";

        while (guessNumber != magicNumber && playAgain != "n")
        {
            guessesCount++;
            Console.Write("What is your guess? ");
            string guessNumberInp = Console.ReadLine();
            guessNumber = int.Parse(guessNumberInp);

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! Your total guesses were: {guessesCount}");
                Console.Write("Would you like to play again? (y/n) ");
                playAgain = Console.ReadLine();
                if (playAgain == "y")
                {
                    magicNumber = randomNum.Next(1, 100);
                    guessNumber = -1;
                    guessesCount = 0;
                }
            }

        }
        
        
    }
}