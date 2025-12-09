using System;

class Program
{
    static void Main(string[] args)
    {
        /*Bonus: Added a streak feature that allows users to see how many goals they have completed. You can see it change after comopleting a task.*/
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
        
    }
}