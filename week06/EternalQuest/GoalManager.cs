using System.Data.Common;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _streak;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    

    public void Start()
    {
        bool running = true;
        
        while (running)
        {
            Console.WriteLine($"\n{GetTotalPoints()}");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
            
            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoalDetails();
            else if (choice == "3") SaveGoals();
            else if (choice == "4") LoadGoals();
            else if (choice == "5") RecordEvent();
            else if (choice == "6") running = false;
        }
    }


    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Goal goal = null;
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description of the goal: ");
        string description = Console.ReadLine();
        if (choice == "1")
        {
            Console.Write("Enter the amount of points associated with this goal: ");
            goal = new SimpleGoal(name, description, int.Parse(Console.ReadLine()));
        }
        else if (choice == "2")
        {
            Console.Write("Enter the amount of points associated with this goal: ");
            goal = new EternalGoal(name, description, int.Parse(Console.ReadLine()));
        }
        else if (choice == "3")
        {
            Console.Write("Enter the number of times this goal needs to be accomplished: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of points: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many bonus points? ");
            int bonus = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, description, points, target, bonus);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }
        _goals.Add(goal);
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("\nEnter the filename to save goals: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nEnter the filename to load goals: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split('|');
            string goalType = parts[0];
            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isCompleted = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (isCompleted) goal.RecordEvent();
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                for (int i = 0; i < amountCompleted; i++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Your current goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        Console.WriteLine("\nEnter the number of the goal you accomplished: ");

        
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
        }
        int pointsEarned = _goals[goalIndex].RecordEvent();
        if (pointsEarned > 0)
        {
            _streak++;
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points! Streak: {_streak}");
        }
        else
        {
            Console.WriteLine("This goal is already complete. No points awarded.");
        }
        _score += pointsEarned;
    }

    public string GetTotalPoints()
    {
        return $"Total points: {_score}";
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }
}