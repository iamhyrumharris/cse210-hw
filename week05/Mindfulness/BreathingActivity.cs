public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"Get Ready...");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDownAnimation(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountUpAnimation(4);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    public void ShowCountDownAnimation(int seconds)
    {
        Console.Write("Bre");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("eeeee");
            Thread.Sleep(1000);
        }
        Console.Write("athe \n");
    }

    public void ShowCountUpAnimation(int seconds)
    {
        Console.Write("Haa");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("aaaa");
            Thread.Sleep(1000);
        }
        Console.Write("aaaa \n");
    }
}