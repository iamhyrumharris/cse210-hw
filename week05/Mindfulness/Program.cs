using System;

class Program
{
    static void Main(string[] args)
    {

        /* Added breathing in and out animations for extra credit*/

        BreathingActivity breathing = new BreathingActivity("Breathing Activity", "Clear your mind and focus on your breathing.", 20);
        ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life. Hopefully this helps you recognize areas in your life.", 30);
        ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can.", 30);

        Console.WriteLine("Welcome to the Mindfulness App!");
        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Enter the number of your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                breathing.Run();
                break;
            case "2":
                reflecting.Run();
                break;
            case "3":
                listing.Run();
                break;
            default:
                Console.WriteLine("Please restart the program and select a valid option.");
                break;
        }
    }
}