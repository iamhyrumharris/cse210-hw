using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Hyrum", "Math");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("eliza", "english", "adjectives", "5");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(mathAssignment.GetSummary());

        WritingAssignment writingAssignment = new WritingAssignment("Lee", "revolution", "How It Happened");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}