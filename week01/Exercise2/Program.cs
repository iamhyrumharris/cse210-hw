using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter = "";
        string plusMinusSign = "";

        Console.Write("What grade did you receive in CSE210? ");
        string grade = Console.ReadLine();
        int numGrade = int.Parse(grade);
        int plusMinus = numGrade % 10;

        if (plusMinus >= 7)
        {
            plusMinusSign = "+";
        }
        else if (plusMinus < 3)
        {
            plusMinusSign = "-";
        }
        else
        {
            plusMinusSign = "";
        }


        if (numGrade >= 90)
        {
            if (numGrade >= 97)
            {
                gradeLetter = "A";
            }
            else gradeLetter = ($"A{plusMinusSign}");
        }
        else if (numGrade >= 80)
        {
            gradeLetter = ($"B{plusMinusSign}");
        }
        else if (numGrade >= 70)
        {
            gradeLetter = ($"C{plusMinusSign}");
        }
        else if (numGrade >= 60)
        {
            gradeLetter = ($"D{plusMinusSign}");
        }
        else Console.WriteLine("F");

        Console.WriteLine(gradeLetter);

        if (numGrade >= 70)
        {
            Console.WriteLine("Congratuations!");
        }
        else
        {
            Console.WriteLine("Try again! You got this!");
        }
    }
}