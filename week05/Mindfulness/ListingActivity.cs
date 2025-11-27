using System.Net.NetworkInformation;

public class ListingActivity : Activity
{
    List<string> _prompt = new List<string>()
    {
        "Who are the people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When  have you felt the Holy Ghost?",
        "Who are some of your personal heros?"
    };
    public class _count;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt: \n");

        GetRandomPrompt();

        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);

        Console.WriteLine("-------");

        List<string> responses = GetListFromUser();

        Console.WriteLine($"\nYou listed {responses.Count} items!");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int num = rand.Next(_prompt.Count);
        Console.WriteLine($"{_prompt[num]}");
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">>> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }
        return responses;
    }
}