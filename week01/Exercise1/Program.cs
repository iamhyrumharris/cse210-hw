using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write($"What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}

/*
Results:
What is your first name? Hyrum
What is your last name? Harris
Your name is Harris, Hyrum Harris.
*/