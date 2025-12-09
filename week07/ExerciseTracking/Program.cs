using System;

class Program
{
    static void Main(string[] args)
    {
        Activity swim = new Swimming("2025-12-15", 38, 20);
        Activity run = new Running("2025-12-16", 43, 5);
        Activity bike = new Biking("2025-12-17", 57, 15);
        Console.WriteLine(swim.GetSummary());
        Console.WriteLine(run.GetSummary());
        Console.WriteLine(bike.GetSummary());
    }
}