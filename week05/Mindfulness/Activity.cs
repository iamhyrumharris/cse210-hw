using Microsoft.VisualBasic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome.... \n");
        Console.WriteLine(_description);
        Console.WriteLine("---------------");        
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("--------");
        Console.WriteLine($"Well Done. You finished the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>() { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
        }
    }

    protected void ShowCountDown(int seconds)
    {
        if (seconds < 1)
        {
            return;
        }

        for (int i = seconds; i > 1; i--)
        {
            string s = i.ToString();
            Console.Write(s);
            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }
}