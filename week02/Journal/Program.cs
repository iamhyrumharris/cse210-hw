using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Menu Options:
        1. Write in Journal
        2. Display Journal Entries
        3. Save Journal to File
        4. Load Journal from File
        5. Exit
        */

        // !!! extra credit: save as csv file and load from csv file
        // Able to open the file in excel


        Journal _journal = new Journal();
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write in Journal");
            Console.WriteLine("2. Display Journal Entries");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit");
            Console.Write("Input: ");
            string userChoice = Console.ReadLine();
            Console.Write(userChoice);
            if (userChoice == "1")
            {
                DateTime now = DateTime.Now;
                string nowDate = now.ToString("G");
                RandomPrompt prompt = new RandomPrompt();
                string ranPrompt = prompt.PickRandomPrompt();
                Console.WriteLine(nowDate);
                Console.WriteLine(ranPrompt);
                Console.Write("Response: ");
                string response = Console.ReadLine();
                Entry entry = new Entry(nowDate, ranPrompt, response);

                _journal.AddEntry(entry);
            }
            else if (userChoice == "2")
            {
                _journal.Display();
            }
            else if (userChoice == "3")
            {
                Console.Write("Name of file: ");
                string filename = Console.ReadLine();
                _journal.SaveToFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.Write("Name of file: ");
                string filename = Console.ReadLine();
                _journal.LoadFromFile(filename);
            }
            else if (userChoice == "5")
            {
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Please select a valid option.");
            }
        }
    }
}

