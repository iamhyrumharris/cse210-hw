using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> nums = new List<string>();
        string userInput = "";
        int sum = 0;
        int lgstNum = 0;
        while (userInput != "0")
        {
            Console.Write("Please add a number: ");
            userInput = Console.ReadLine();
            if (userInput != "0")
            {
                nums.Add(userInput);
            }

        }
        foreach (string word in nums)
        {
            int number = int.Parse(word);
            sum = sum + number;
            if (number > lgstNum)
            {
                lgstNum = number;
            }
        }
        Console.WriteLine(($"The sum is: {sum}"));
        Console.WriteLine("The average is: " + ((float)sum / nums.Count));
        Console.Write($"The largest number is: {lgstNum}");
    }
}