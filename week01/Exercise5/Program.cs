using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userSqNum = SquareNumber(PromptUserNumber());
        DisplayResult(userName, userSqNum);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Class!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();
            return firstName + " " + lastName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string favNumInp = Console.ReadLine();
            int favNum = int.Parse(favNumInp);
            return favNum;
        }

        static int SquareNumber(int userInp)
        {
            int squaredNum = userInp * userInp;
            return squaredNum;
        }

        static void DisplayResult(string nameOfUser, int sqNumOfUser)
        {
            Console.Write($"{nameOfUser}, the sqaure of your number is {sqNumOfUser}");
        }
        
    }
}